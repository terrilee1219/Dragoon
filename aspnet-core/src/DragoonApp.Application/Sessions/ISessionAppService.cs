using System.Threading.Tasks;
using Abp.Application.Services;
using DragoonApp.Sessions.Dto;

namespace DragoonApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
