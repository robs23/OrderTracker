using Microsoft.EntityFrameworkCore;
using OrderTracker.API.Models;

namespace OrderTracker.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<OT_Tenant> OT_Tenants {get;set;}

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     if (!optionsBuilder.IsConfigured)
        //     {
        //         optionsBuilder.UseSqlServer(Conf);
        //     }
        // }
    }
}