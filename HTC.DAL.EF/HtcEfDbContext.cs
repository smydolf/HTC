using System.Data.Entity;
using HTCDOMAIN;
using HTCDOMAIN.Abstract;

namespace HTC.DAL.EF
{
    public class HtcEfDbContext : DbContext
    {
        public HtcEfDbContext()
        {
        }

        public DbSet<Driver> Drivers { get; set; } //TODO
        public DbSet<Products> Products { get; set; }

    }
}
