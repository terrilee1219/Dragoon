using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DragoonApp.MultiTenancy.Dto;

namespace DragoonApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

