using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using donet_vue_admin.Configuration;

namespace donet_vue_admin.Web.Host.Startup
{
    [DependsOn(
       typeof(donet_vue_adminWebCoreModule))]
    public class donet_vue_adminWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public donet_vue_adminWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(donet_vue_adminWebHostModule).GetAssembly());
        }
    }
}
