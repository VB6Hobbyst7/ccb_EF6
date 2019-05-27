namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BordadosCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bordadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Arquivo = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Caminho = c.String(maxLength: 255, storeType: "nvarchar"),
                        Disquete = c.String(maxLength: 12, storeType: "nvarchar"),
                        Bastidor = c.String(maxLength: 12, storeType: "nvarchar"),
                        Inscr_Estadual = c.String(maxLength: 20, storeType: "nvarchar"),
                        Grupo_id = c.Int(nullable: false),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pontos = c.Int(nullable: false),
                        Cores = c.Int(nullable: false),
                        Largura = c.Int(nullable: false),
                        Altura = c.Int(nullable: false),
                        Metragem = c.Int(nullable: false),
                        Aprovado = c.Boolean(nullable: false),
                        Imagem = c.Binary(),
                        ObsPublica = c.String(maxLength: 1024, storeType: "nvarchar"),
                        ObsPrivada = c.String(maxLength: 1024, storeType: "nvarchar"),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bordadoes");
        }
    }
}
