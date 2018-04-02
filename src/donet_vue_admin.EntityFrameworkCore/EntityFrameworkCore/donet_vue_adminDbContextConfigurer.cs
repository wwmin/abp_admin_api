using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace donet_vue_admin.EntityFrameworkCore
{
    public static class donet_vue_adminDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<donet_vue_adminDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<donet_vue_adminDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
