using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.Extensions;
using Framework.Authorization.Users;
using Framework.Validation;

namespace Framework.Authorization.Accounts.Dto
{
    public enum ClientType
    { 
        WEB, MOBILE
    }
    public class RegisterInput : IValidatableObject
    {
        [Required]
        public ClientType ClientType { get; set; }
        public string OTP { get; set; }

        [StringLength(AbpUserBase.MaxNameLength)]
        public string Name { get; set; }

        [StringLength(AbpUserBase.MaxSurnameLength)]
        public string Surname { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxNameLength + AbpUserBase.MaxSurnameLength)]
        public string FullName { get; set; }

        [StringLength(AbpUserBase.MaxUserNameLength)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

        [StringLength(UserConsts.MaxPhoneNumberLength)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(UserConsts.MaxGenderLength)]
        public string Gender { get; set; }

        [Required]
        [MaxLength(UserConsts.MaxIDNumberLength)]
        public string IDNumber { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string Password { get; set; }

        [DisableAuditing]
        public string CaptchaResponse { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!UserName.IsNullOrEmpty())
            {
                if (!UserName.Equals(EmailAddress, StringComparison.OrdinalIgnoreCase) && ValidationHelper.IsEmail(UserName))
                {
                    yield return new ValidationResult("Username cannot be an email address unless it's same with your email address !");
                }
            }
        }
    }
}