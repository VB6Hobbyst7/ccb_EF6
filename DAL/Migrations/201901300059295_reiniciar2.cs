namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reiniciar2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Contato_Funcao", c => c.String(maxLength: 20, storeType: "nvarchar"));
            AlterColumn("dbo.Clientes", "Endereco", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Endereco", c => c.String(maxLength: 300, storeType: "nvarchar"));
            AlterColumn("dbo.Clientes", "Contato_Funcao", c => c.String(nullable: false, maxLength: 20, storeType: "nvarchar"));
        }
    }
}
