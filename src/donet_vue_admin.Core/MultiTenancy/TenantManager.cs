using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using donet_vue_admin.Authorization.Users;
using donet_vue_admin.Editions;

namespace donet_vue_admin.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
