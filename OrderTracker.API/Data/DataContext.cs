using Microsoft.EntityFrameworkCore;
using OrderTracker.API.Models;

namespace OrderTracker.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DbContext> options) : base(options)
        {
            
        }

        DbSet<OT_Tenant> Tenants {get;set;}
    }
}