namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reiniciar1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "telefone1", c => c.String(maxLength: 15, storeType: "nvarchar"));
            AlterColumn("dbo.Clientes", "telefone2", c => c.String(maxLength: 15, storeType: "nvarchar"));
            AlterColumn("dbo.Clientes", "telefone3", c => c.String(maxLength: 15, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "telefone3", c => c.String(maxLength: 10, storeType: "nvarchar"));
            AlterColumn("dbo.Clientes", "telefone2", c => c.String(maxLength: 10, storeType: "nvarchar"));
            AlterColumn("dbo.Clientes", "telefone1", c => c.String(maxLength: 10, storeType: "nvarchar"));
        }
    }
}
