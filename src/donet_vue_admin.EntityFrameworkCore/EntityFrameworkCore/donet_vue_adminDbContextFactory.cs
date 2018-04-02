using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using donet_vue_admin.Configuration;
using donet_vue_admin.Web;

namespace donet_vue_admin.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class donet_vue_adminDbContextFactory : IDesignTimeDbContextFactory<donet_vue_adminDbContext>
    {
        public donet_vue_adminDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<donet_vue_adminDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            donet_vue_adminDbContextConfigurer.Configure(builder, configuration.GetConnectionString(donet_vue_adminConsts.ConnectionStringName));

            return new donet_vue_adminDbContext(builder.Options);
        }
    }
}
