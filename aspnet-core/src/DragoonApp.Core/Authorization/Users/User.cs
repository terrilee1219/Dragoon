using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Abp.Authorization.Users;
using Abp.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DragoonApp.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

        public string StudentNumber { get; set; }
        public TypeOfUser typeOfUser { get; set; }

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Roles = new List<UserRole>()
            };

            user.SetNormalizedNames();

            return user;
        }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeOfUser
    {
        [EnumMember(Value = "Student")]
        Student,
        [EnumMember(Value = "Staff")]
        Staff
    }
}
