namespace HTC.DAL.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        PrimaryKey = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.PrimaryKey);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        PrimaryKey = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PrimaryKey);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        PrimaryKey = c.Guid(nullable: false),
                        Code = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Product_PrimaryKey = c.Guid(),
                        Size_PrimaryKey = c.Guid(),
                    })
                .PrimaryKey(t => t.PrimaryKey)
                .ForeignKey("dbo.Product", t => t.Product_PrimaryKey)
                .ForeignKey("dbo.Size", t => t.Size_PrimaryKey)
                .Index(t => t.Product_PrimaryKey)
                .Index(t => t.Size_PrimaryKey);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        PrimaryKey = c.Guid(nullable: false),
                        Name = c.String(),
                        Category_PrimaryKey = c.Guid(),
                    })
                .PrimaryKey(t => t.PrimaryKey)
                .ForeignKey("dbo.Category", t => t.Category_PrimaryKey)
                .Index(t => t.Category_PrimaryKey);
            
            CreateTable(
                "dbo.Size",
                c => new
                    {
                        PrimaryKey = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PrimaryKey);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        PrimaryKey = c.Guid(nullable: false),
                        OrderDetail_PrimaryKey = c.Guid(),
                        Purchaser_PrimaryKey = c.Guid(),
                        User_PrimaryKey = c.Guid(),
                    })
                .PrimaryKey(t => t.PrimaryKey)
                .ForeignKey("dbo.OrderDetail", t => t.OrderDetail_PrimaryKey)
                .ForeignKey("dbo.Purchaser", t => t.Purchaser_PrimaryKey)
                .ForeignKey("dbo.User", t => t.User_PrimaryKey)
                .Index(t => t.OrderDetail_PrimaryKey)
                .Index(t => t.Purchaser_PrimaryKey)
                .Index(t => t.User_PrimaryKey);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        PrimaryKey = c.Guid(nullable: false),
                        Amount = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Menu_PrimaryKey = c.Guid(),
                    })
                .PrimaryKey(t => t.PrimaryKey)
                .ForeignKey("dbo.Menu", t => t.Menu_PrimaryKey)
                .Index(t => t.Menu_PrimaryKey);
            
            CreateTable(
                "dbo.Purchaser",
                c => new
                    {
                        PrimaryKey = c.Guid(nullable: false),
                        Name = c.String(),
                        Street = c.String(),
                        PhoneNumber = c.String(),
                        Address_PrimaryKey = c.Guid(),
                    })
                .PrimaryKey(t => t.PrimaryKey)
                .ForeignKey("dbo.Address", t => t.Address_PrimaryKey)
                .Index(t => t.Address_PrimaryKey);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        PrimaryKey = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Role_PrimaryKey = c.Guid(),
                    })
                .PrimaryKey(t => t.PrimaryKey)
                .ForeignKey("dbo.UserRole", t => t.Role_PrimaryKey)
                .Index(t => t.Role_PrimaryKey);
            
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        PrimaryKey = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PrimaryKey);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order", "User_PrimaryKey", "dbo.User");
            DropForeignKey("dbo.User", "Role_PrimaryKey", "dbo.UserRole");
            DropForeignKey("dbo.Order", "Purchaser_PrimaryKey", "dbo.Purchaser");
            DropForeignKey("dbo.Purchaser", "Address_PrimaryKey", "dbo.Address");
            DropForeignKey("dbo.Order", "OrderDetail_PrimaryKey", "dbo.OrderDetail");
            DropForeignKey("dbo.OrderDetail", "Menu_PrimaryKey", "dbo.Menu");
            DropForeignKey("dbo.Menu", "Size_PrimaryKey", "dbo.Size");
            DropForeignKey("dbo.Menu", "Product_PrimaryKey", "dbo.Product");
            DropForeignKey("dbo.Product", "Category_PrimaryKey", "dbo.Category");
            DropIndex("dbo.User", new[] { "Role_PrimaryKey" });
            DropIndex("dbo.Purchaser", new[] { "Address_PrimaryKey" });
            DropIndex("dbo.OrderDetail", new[] { "Menu_PrimaryKey" });
            DropIndex("dbo.Order", new[] { "User_PrimaryKey" });
            DropIndex("dbo.Order", new[] { "Purchaser_PrimaryKey" });
            DropIndex("dbo.Order", new[] { "OrderDetail_PrimaryKey" });
            DropIndex("dbo.Product", new[] { "Category_PrimaryKey" });
            DropIndex("dbo.Menu", new[] { "Size_PrimaryKey" });
            DropIndex("dbo.Menu", new[] { "Product_PrimaryKey" });
            DropTable("dbo.UserRole");
            DropTable("dbo.User");
            DropTable("dbo.Purchaser");
            DropTable("dbo.OrderDetail");
            DropTable("dbo.Order");
            DropTable("dbo.Size");
            DropTable("dbo.Product");
            DropTable("dbo.Menu");
            DropTable("dbo.Category");
            DropTable("dbo.Address");
        }
    }
}
