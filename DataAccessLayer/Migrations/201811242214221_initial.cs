namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        UserName = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.OrderSushi",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        SushiId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderId, t.SushiId })
                .ForeignKey("dbo.Sushi", t => t.SushiId, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.SushiId);
            
            CreateTable(
                "dbo.Sushi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order", "CustomerId", "dbo.Customer");
            DropForeignKey("dbo.OrderSushi", "OrderId", "dbo.Order");
            DropForeignKey("dbo.OrderSushi", "SushiId", "dbo.Sushi");
            DropIndex("dbo.OrderSushi", new[] { "SushiId" });
            DropIndex("dbo.OrderSushi", new[] { "OrderId" });
            DropIndex("dbo.Order", new[] { "CustomerId" });
            DropTable("dbo.Sushi");
            DropTable("dbo.OrderSushi");
            DropTable("dbo.Order");
            DropTable("dbo.Customer");
        }
    }
}
