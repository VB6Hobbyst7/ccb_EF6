namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinhaCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Linhas",
                c => new
                    {
                        Codigo = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Nome = c.String(nullable: false, maxLength: 30, storeType: "nvarchar"),
                        MaterialNome = c.String(maxLength: 20, storeType: "nvarchar"),
                        MaterialFabricante = c.String(maxLength: 20, storeType: "nvarchar"),
                        MaterialTipo = c.String(maxLength: 20, storeType: "nvarchar"),
                        Cor = c.Int(nullable: false),
                        Estoque_1 = c.Int(nullable: false),
                        Estoque_2 = c.Int(nullable: false),
                        Minimo = c.Int(nullable: false),
                        Pedido = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Linhas");
        }
    }
}
