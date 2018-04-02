using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using donet_vue_admin.Authorization.Roles;
using donet_vue_admin.Authorization.Users;
using donet_vue_admin.MultiTenancy;

namespace donet_vue_admin.EntityFrameworkCore
{
    public class donet_vue_adminDbContext : AbpZeroDbContext<Tenant, Role, User, donet_vue_adminDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public donet_vue_adminDbContext(DbContextOptions<donet_vue_adminDbContext> options)
            : base(options)
        {
        }
    }
}
