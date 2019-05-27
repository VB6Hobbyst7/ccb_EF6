namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FornecedorCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fornecedors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120, storeType: "nvarchar"),
                        Contato_Funcao = c.String(maxLength: 20, storeType: "nvarchar"),
                        Contato_Nome = c.String(maxLength: 50, storeType: "nvarchar"),
                        Cgc_Cpf = c.String(maxLength: 20, storeType: "nvarchar"),
                        Inscr_Estadual = c.String(maxLength: 20, storeType: "nvarchar"),
                        Endereco = c.String(unicode: false),
                        Cidade = c.String(maxLength: 20, storeType: "nvarchar"),
                        Estado = c.String(maxLength: 2, storeType: "nvarchar"),
                        Cep = c.String(maxLength: 9, storeType: "nvarchar"),
                        Telefone1 = c.String(maxLength: 15, storeType: "nvarchar"),
                        Telefone2 = c.String(maxLength: 15, storeType: "nvarchar"),
                        Telefone3 = c.String(maxLength: 15, storeType: "nvarchar"),
                        Email = c.String(maxLength: 60, storeType: "nvarchar"),
                        Obs = c.String(maxLength: 512, storeType: "nvarchar"),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fornecedores");
        }
    }
}
