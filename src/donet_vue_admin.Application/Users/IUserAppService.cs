using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using donet_vue_admin.Roles.Dto;
using donet_vue_admin.Users.Dto;

namespace donet_vue_admin.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
