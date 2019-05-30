namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
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
            
            CreateTable(
                "dbo.BordadoLinhas",
                c => new
                    {
                        BordadoId = c.Int(nullable: false),
                        LinhaCodigo = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        seq = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BordadoId, t.LinhaCodigo })
                .ForeignKey("dbo.Bordados", t => t.BordadoId, cascadeDelete: true)
                .ForeignKey("dbo.Linhas", t => t.LinhaCodigo, cascadeDelete: true)
                .Index(t => t.BordadoId)
                .Index(t => t.LinhaCodigo);
            
            CreateTable(
                "dbo.Bordados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Arquivo = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Caminho = c.String(maxLength: 255, storeType: "nvarchar"),
                        Descricao = c.String(maxLength: 50, storeType: "nvarchar"),
                        Disquete = c.String(maxLength: 12, storeType: "nvarchar"),
                        Bastidor = c.String(maxLength: 12, storeType: "nvarchar"),
                        Grupo_Id = c.Int(nullable: false),
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
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            CreateTable(
                "dbo.Clientes",
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
                        Preco_Base = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fornecedores",
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
            DropForeignKey("dbo.BordadoLinhas", "LinhaCodigo", "dbo.Linhas");
            DropForeignKey("dbo.BordadoLinhas", "BordadoId", "dbo.Bordados");
            DropForeignKey("dbo.Transactions", "UserID", "dbo.Users");
            DropForeignKey("dbo.Transactions", "CustomerID", "dbo.Accounts");
            DropForeignKey("dbo.Accounts", "CustomerID", "dbo.Customers");
            DropIndex("dbo.BordadoLinhas", new[] { "LinhaCodigo" });
            DropIndex("dbo.BordadoLinhas", new[] { "BordadoId" });
            DropIndex("dbo.Transactions", new[] { "UserID" });
            DropIndex("dbo.Transactions", new[] { "CustomerID" });
            DropIndex("dbo.Accounts", new[] { "CustomerID" });
            DropTable("dbo.Fornecedores");
            DropTable("dbo.Clientes");
            DropTable("dbo.Linhas");
            DropTable("dbo.Bordados");
            DropTable("dbo.BordadoLinhas");
            DropTable("dbo.ApplicationSettings");
            DropTable("dbo.Users");
            DropTable("dbo.Transactions");
            DropTable("dbo.Customers");
            DropTable("dbo.Accounts");
        }
    }
}
