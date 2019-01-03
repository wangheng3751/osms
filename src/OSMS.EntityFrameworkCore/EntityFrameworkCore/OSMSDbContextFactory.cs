using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using OSMS.Configuration;
using OSMS.Web;

namespace OSMS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class OSMSDbContextFactory : IDesignTimeDbContextFactory<OSMSDbContext>
    {
        public OSMSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OSMSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            OSMSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(OSMSConsts.ConnectionStringName));

            return new OSMSDbContext(builder.Options);
        }
    }
}
