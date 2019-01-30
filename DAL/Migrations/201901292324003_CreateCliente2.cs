namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCliente2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "inscr_estadual", c => c.String(maxLength: 20, storeType: "nvarchar"));
            AddColumn("dbo.Clientes", "preco_base", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "preco_base");
            DropColumn("dbo.Clientes", "inscr_estadual");
        }
    }
}
