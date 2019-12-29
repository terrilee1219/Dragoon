using System.Threading.Tasks;
using Abp.Application.Services;
using DragoonApp.Authorization.Accounts.Dto;

namespace DragoonApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
