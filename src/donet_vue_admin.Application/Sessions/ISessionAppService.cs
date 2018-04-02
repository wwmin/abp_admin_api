using System.Threading.Tasks;
using Abp.Application.Services;
using donet_vue_admin.Sessions.Dto;

namespace donet_vue_admin.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
