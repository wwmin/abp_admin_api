using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using donet_vue_admin.Roles.Dto;

namespace donet_vue_admin.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
