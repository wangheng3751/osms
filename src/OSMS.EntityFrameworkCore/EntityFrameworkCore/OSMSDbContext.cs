using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OSMS.Authorization.Roles;
using OSMS.Authorization.Users;
using OSMS.MultiTenancy;

namespace OSMS.EntityFrameworkCore
{
    public class OSMSDbContext : AbpZeroDbContext<Tenant, Role, User, OSMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Reconcilia.SellOrders.SellOrder> SellOrder { get; set; }

        public OSMSDbContext(DbContextOptions<OSMSDbContext> options)
            : base(options)
        {
        }
    }
}
