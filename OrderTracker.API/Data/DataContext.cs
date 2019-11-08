using Microsoft.EntityFrameworkCore;
using OrderTracker.API.Models;

namespace OrderTracker.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        DbSet<OT_Tenant> Tenants {get;set;}

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     if (!optionsBuilder.IsConfigured)
        //     {
        //         optionsBuilder.UseSqlServer(Conf);
        //     }
        // }
    }
}