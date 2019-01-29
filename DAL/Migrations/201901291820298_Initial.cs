namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        CustomerID = c.Int(nullable: false),
                        DateClosed = c.DateTime(precision: 0),
                        CurrentPointsBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Active = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Names = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        PaternalLastname = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        MaternalLastname = c.String(maxLength: 50, storeType: "nvarchar"),
                        Address = c.String(maxLength: 300, storeType: "nvarchar"),
                        Phone = c.String(maxLength: 10, storeType: "nvarchar"),
                        Cellphone = c.String(maxLength: 10, storeType: "nvarchar"),
                        Email = c.String(maxLength: 50, storeType: "nvarchar"),
                        Nickname = c.String(maxLength: 100, storeType: "nvarchar"),
                        Username = c.String(maxLength: 100, storeType: "nvarchar"),
                        Password = c.String(maxLength: 32, storeType: "nvarchar"),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionID = c.Int(nullable: false, identity: true),
                        TransactionCode = c.Guid(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        TransactionDate = c.DateTime(nullable: false, precision: 0),
                        Description = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        TransactionType = c.Int(nullable: false),
                        Notes = c.String(maxLength: 500, storeType: "nvarchar"),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.TransactionID)
                .ForeignKey("dbo.Accounts", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, unicode: false),
                        PaternalLastname = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        MaternalLastname = c.String(maxLength: 50, storeType: "nvarchar"),
                        Address = c.String(maxLength: 300, storeType: "nvarchar"),
                        Phone = c.String(maxLength: 10, storeType: "nvarchar"),
                        Cellphone = c.String(maxLength: 10, storeType: "nvarchar"),
                        Email = c.String(maxLength: 50, storeType: "nvarchar"),
                        Alias = c.String(maxLength: 50, storeType: "nvarchar"),
                        Username = c.String(maxLength: 100, storeType: "nvarchar"),
                        Password = c.String(unicode: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.ApplicationSettings",
                c => new
                    {
                        ApplicationSettingID = c.Int(nullable: false, identity: true),
                        BusinessName = c.String(maxLength: 100, storeType: "nvarchar"),
                        BusinessAddress = c.String(maxLength: 300, storeType: "nvarchar"),
                        BusinessPhone = c.String(maxLength: 10, storeType: "nvarchar"),
                        BusinessEmail = c.String(maxLength: 100, storeType: "nvarchar"),
                        BusinessWebsite = c.String(maxLength: 100, storeType: "nvarchar"),
                        BusinessAnniversary = c.DateTime(nullable: false, precision: 0),
                        Logo = c.Binary(),
                        PercentagePoints = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PointValueCash = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RewardDoublePointsOnBusinessAnniversary = c.Boolean(nullable: false),
                        RewardDoublePointsOnCustomerAnniversary = c.Boolean(nullable: false),
                        AllowCashRequest = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.ApplicationSettingID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "UserID", "dbo.Users");
            DropForeignKey("dbo.Transactions", "CustomerID", "dbo.Accounts");
            DropForeignKey("dbo.Accounts", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Transactions", new[] { "UserID" });
            DropIndex("dbo.Transactions", new[] { "CustomerID" });
            DropIndex("dbo.Accounts", new[] { "CustomerID" });
            DropTable("dbo.ApplicationSettings");
            DropTable("dbo.Users");
            DropTable("dbo.Transactions");
            DropTable("dbo.Customers");
            DropTable("dbo.Accounts");
        }
    }
}
