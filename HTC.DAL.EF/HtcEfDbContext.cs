using System.Data.Entity;
using HTCDOMAIN.AbstractDB;

namespace HTC.DAL.EF
{
    public class HtcEfDbContext : DbContext
    {
        public DbSet<AddressDbObject> AddressDbObject { get; set; }
        public DbSet<CategoryDbObject> CategoryDbObject { get; set; }
        public DbSet<MenuDbObject> MenuDbObject { get; set; }
        public DbSet<OrderDbObject> OrderDbObject { get; set; }
        public DbSet<OrderDetailDbObject> OrderDetailDbObject { get; set; }
        public DbSet<ProductDbObject> ProductDbObject { get; set; }
        public DbSet<PurchaserDbObject> PurchaserDbObject { get; set; }
        public DbSet<SizeDbObject> SizeDbObject { get; set; }
        public DbSet<UserDbObject> UserDbObject { get; set; }
        public DbSet<UserRoleDbObject> UserRoleDbObject { get; set; }
    }
}
