using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using DragoonApp.MultiTenancy;

namespace DragoonApp.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
