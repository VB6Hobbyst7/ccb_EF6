namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reiniciar : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "contato_nome", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AlterColumn("dbo.Clientes", "cgc_cpf", c => c.String(maxLength: 20, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "cgc_cpf", c => c.String(maxLength: 18, storeType: "nvarchar"));
            AlterColumn("dbo.Clientes", "contato_nome", c => c.String(maxLength: 20, storeType: "nvarchar"));
        }
    }
}
