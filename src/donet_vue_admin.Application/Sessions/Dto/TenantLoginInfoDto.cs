using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using donet_vue_admin.MultiTenancy;

namespace donet_vue_admin.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
