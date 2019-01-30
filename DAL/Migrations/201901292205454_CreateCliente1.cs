namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCliente1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 120, storeType: "nvarchar"),
                        contato_funcao = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        contato_nome = c.String(maxLength: 20, storeType: "nvarchar"),
                        cgc_cpf = c.String(maxLength: 18, storeType: "nvarchar"),
                        Endereco = c.String(maxLength: 300, storeType: "nvarchar"),
                        cidade = c.String(maxLength: 20, storeType: "nvarchar"),
                        estado = c.String(maxLength: 2, storeType: "nvarchar"),
                        cep = c.String(maxLength: 9, storeType: "nvarchar"),
                        telefone1 = c.String(maxLength: 10, storeType: "nvarchar"),
                        telefone2 = c.String(maxLength: 10, storeType: "nvarchar"),
                        telefone3 = c.String(maxLength: 10, storeType: "nvarchar"),
                        email = c.String(maxLength: 60, storeType: "nvarchar"),
                        obs = c.String(maxLength: 512, storeType: "nvarchar"),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
