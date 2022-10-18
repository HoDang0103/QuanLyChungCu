﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using Abp.Configuration;
using Abp.IdentityFramework;
using Abp.Linq;
using Abp.Notifications;
using Abp.Runtime.Session;
using Abp.UI;
using Microsoft.AspNetCore.Identity;
using Framework.Authorization.Roles;
using Framework.Configuration;
using Framework.Debugging;
using Framework.MultiTenancy;
using Framework.Notifications;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Framework.Authorization.Accounts.Dto;

namespace Framework.Authorization.Users
{
    public class UserRegistrationManager : FrameworkDomainServiceBase
    {
        public IAbpSession AbpSession { get; set; }
        public IAsyncQueryableExecuter AsyncQueryableExecuter { get; set; }

        private readonly TenantManager _tenantManager;
        private readonly UserManager _userManager;
        private readonly RoleManager _roleManager;
        private readonly IUserEmailer _userEmailer;
        private readonly INotificationSubscriptionManager _notificationSubscriptionManager;
        private readonly IAppNotifier _appNotifier;
        private readonly IUserPolicy _userPolicy;


        public UserRegistrationManager(
            TenantManager tenantManager,
            UserManager userManager,
            RoleManager roleManager,
            IUserEmailer userEmailer,
            INotificationSubscriptionManager notificationSubscriptionManager,
            IAppNotifier appNotifier,
            IUserPolicy userPolicy)
        {
            _tenantManager = tenantManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _userEmailer = userEmailer;
            _notificationSubscriptionManager = notificationSubscriptionManager;
            _appNotifier = appNotifier;
            _userPolicy = userPolicy;

            AbpSession = NullAbpSession.Instance;
            AsyncQueryableExecuter = NullAsyncQueryableExecuter.Instance;
        }

        public async Task<User> RegisterAsync(
            string emailAddress,
            string plainPassword,
            string fullName,
            string gender,
            string idNumber,
            DateTime birthDate,
            bool isEmailConfirmed,
            string emailActivationString,
            ClientType clientType)
        {
            CheckForTenant();
            CheckSelfRegistrationIsEnabled();

            var tenant = await GetActiveTenantAsync();
            var isNewRegisteredUserActiveByDefault = await SettingManager.GetSettingValueAsync<bool>(AppSettings.UserManagement.IsNewRegisteredUserActiveByDefault);

            await _userPolicy.CheckMaxUserCountAsync(tenant.Id);

            // splitting fullname to surname + name (vietnamese format)
            string[] fullNameSplitted = fullName.Split(" ");
            int nameIndex = fullNameSplitted.Length - 1;
            string name = CapitalizeName(fullNameSplitted[nameIndex]);
            string surname = CapitalizeName(fullName.Substring(0, fullName.Length - fullNameSplitted[nameIndex].Length));

            var user = new User
            {
                TenantId = tenant.Id,
                Name = name,
                Surname = surname,
                EmailAddress = emailAddress,
                UserName = emailAddress,
                IsEmailConfirmed = isEmailConfirmed,
                Roles = new List<UserRole>(),
                Gender = gender,
                IDNumber = idNumber,
                BirthDate = birthDate,
            };

            if (clientType == ClientType.WEB)
            {
                user.IsActive = isNewRegisteredUserActiveByDefault;
                user.EmailConfirmationCode = emailActivationString;
            }
            else // (clientType == ClientType.MOBILE)
            {
                user.IsActive = isNewRegisteredUserActiveByDefault;
                user.EmailConfirmationCode = emailActivationString;
            };

            user.SetNormalizedNames();

            var defaultRoles = await AsyncQueryableExecuter.ToListAsync(_roleManager.Roles.Where(r => r.IsDefault));
            foreach (var defaultRole in defaultRoles)
            {
                user.Roles.Add(new UserRole(tenant.Id, user.Id, defaultRole.Id));
            }

            await _userManager.InitializeOptionsAsync(AbpSession.TenantId);
            CheckErrors(await _userManager.CreateAsync(user, plainPassword));
            await CurrentUnitOfWork.SaveChangesAsync();

            /*  To send Email activation link if needed */
            if (!user.IsEmailConfirmed && clientType == ClientType.WEB)
            {
                user.SetNewEmailConfirmationCode();
                await _userEmailer.SendEmailActivationLinkAsync(user, emailActivationString);
            }

            //Notifications
            await _notificationSubscriptionManager.SubscribeToAllAvailableNotificationsAsync(user.ToUserIdentifier());
            await _appNotifier.WelcomeToTheApplicationAsync(user);
            await _appNotifier.NewUserRegisteredAsync(user);
            return user;
        }

        private void CheckForTenant()
        {
            if (!AbpSession.TenantId.HasValue)
            {
                throw new InvalidOperationException("Can not register host users!");
            }
        }

        private void CheckSelfRegistrationIsEnabled()
        {
            if (!SettingManager.GetSettingValue<bool>(AppSettings.UserManagement.AllowSelfRegistration))
            {
                throw new UserFriendlyException(L("SelfUserRegistrationIsDisabledMessage_Detail"));
            }
        }

        private bool UseCaptchaOnRegistration()
        {
            return SettingManager.GetSettingValue<bool>(AppSettings.UserManagement.UseCaptchaOnRegistration);
        }

        private async Task<Tenant> GetActiveTenantAsync()
        {
            if (!AbpSession.TenantId.HasValue)
            {
                return null;
            }

            return await GetActiveTenantAsync(AbpSession.TenantId.Value);
        }

        private async Task<Tenant> GetActiveTenantAsync(int tenantId)
        {
            var tenant = await _tenantManager.FindByIdAsync(tenantId);
            if (tenant == null)
            {
                throw new UserFriendlyException(L("UnknownTenantId{0}", tenantId));
            }

            if (!tenant.IsActive)
            {
                throw new UserFriendlyException(L("TenantIdIsNotActive{0}", tenantId));
            }

            return tenant;
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }

        private string CapitalizeName(string name)
        {
            string[] nameSplitted = name.Trim().Split(" ");

            if (nameSplitted.Length < 2)
            {
                return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
            }
            else
            {
                name = "";

                foreach (string word in nameSplitted)
                {
                    name += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                }

                return name.Trim();
            }
        }
    }
}
