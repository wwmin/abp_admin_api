using Abp.Application.Services;
using Abp.Application.Services.Dto;
using donet_vue_admin.MultiTenancy.Dto;

namespace donet_vue_admin.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
