using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using donet_vue_admin.Configuration;
using donet_vue_admin.EntityFrameworkCore;
using donet_vue_admin.Migrator.DependencyInjection;

namespace donet_vue_admin.Migrator
{
    [DependsOn(typeof(donet_vue_adminEntityFrameworkModule))]
    public class donet_vue_adminMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public donet_vue_adminMigratorModule(donet_vue_adminEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(donet_vue_adminMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                donet_vue_adminConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(donet_vue_adminMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
