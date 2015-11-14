using System.Data.Entity;
using HTCDOMAIN.Abstract;

namespace HTC.DAL.EF
{
    public class HtcEfDbContext : DbContext
    {      
        public DbSet<Driver> Drivers { get; set; } 
        public DbSet<Products> Products { get; set; }
    }
}
