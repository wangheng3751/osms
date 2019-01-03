using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OSMS.EntityFrameworkCore
{
    public static class OSMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OSMSDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OSMSDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}
