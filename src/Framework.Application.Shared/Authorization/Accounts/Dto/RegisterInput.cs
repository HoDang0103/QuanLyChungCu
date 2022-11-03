using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.Extensions;
using Framework.Authorization.Users;
using Framework.Validation;

namespace Framework.Authorization.Accounts.Dto
{
    public class RegisterInput : IValidatableObject
    {
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
        public string IDNumber { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [StringLength(15)]
        public string ApartmentId { get; set; }

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

            if (!(IDNumber.Length == 9 || IDNumber.Length == 12))
            {
                yield return new ValidationResult("Vui lòng nhập 9 số đối với CMND hoặc 12 số đối với CCCD");
            }
            else
            {
                foreach (char c in IDNumber)
                {
                    if (c < '0' || c > '9')
                    {
                        yield return new ValidationResult("CMND hoặc CCCD không hợp lệ");
                        break;
                    }
                }
            }

            if (!(
                (EmailAddress.Contains("@gmail.com"))
                || (EmailAddress.Contains("@yopmail.com"))  // để test, sau này bỏ
                ))
            {
                yield return new ValidationResult("Vui lòng nhập email đúng quy định. Ví dụ prefix_gi_cung_duoc_nhung_domain_phai_la@gmail.com");
            }
        }
    }
}