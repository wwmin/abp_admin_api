using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using donet_vue_admin.Authorization;

namespace donet_vue_admin
{
    [DependsOn(
        typeof(donet_vue_adminCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class donet_vue_adminApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<donet_vue_adminAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(donet_vue_adminApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
