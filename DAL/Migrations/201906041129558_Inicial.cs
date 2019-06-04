namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
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
                .ForeignKey("dbo.Customer", t => t.CustomerID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Names = c.String(nullable: false, maxLength: 50, unicode: false),
                        PaternalLastname = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaternalLastname = c.String(maxLength: 50, unicode: false),
                        Address = c.String(maxLength: 300, unicode: false),
                        Phone = c.String(maxLength: 10, unicode: false),
                        Cellphone = c.String(maxLength: 10, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        Nickname = c.String(maxLength: 100, unicode: false),
                        Username = c.String(maxLength: 100, unicode: false),
                        Password = c.String(maxLength: 32, unicode: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Transaction",
                c => new
                    {
                        TransactionID = c.Int(nullable: false, identity: true),
                        TransactionCode = c.Guid(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        TransactionDate = c.DateTime(nullable: false, precision: 0),
                        Description = c.String(nullable: false, maxLength: 100, unicode: false),
                        TransactionType = c.Int(nullable: false),
                        Notes = c.String(maxLength: 500, unicode: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.TransactionID)
                .ForeignKey("dbo.Account", t => t.CustomerID)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.CustomerID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        PaternalLastname = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaternalLastname = c.String(maxLength: 50, unicode: false),
                        Address = c.String(maxLength: 300, unicode: false),
                        Phone = c.String(maxLength: 10, unicode: false),
                        Cellphone = c.String(maxLength: 10, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        Alias = c.String(maxLength: 50, unicode: false),
                        Username = c.String(maxLength: 100, unicode: false),
                        Password = c.String(maxLength: 100, unicode: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.ApplicationSetting",
                c => new
                    {
                        ApplicationSettingID = c.Int(nullable: false, identity: true),
                        BusinessName = c.String(maxLength: 100, unicode: false),
                        BusinessAddress = c.String(maxLength: 300, unicode: false),
                        BusinessPhone = c.String(maxLength: 10, unicode: false),
                        BusinessEmail = c.String(maxLength: 100, unicode: false),
                        BusinessWebsite = c.String(maxLength: 100, unicode: false),
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
                "dbo.BordadoLinha",
                c => new
                    {
                        BordadoId = c.Int(nullable: false),
                        LinhaCodigo = c.String(nullable: false, maxLength: 100, unicode: false),
                        seq = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BordadoId, t.LinhaCodigo })
                .ForeignKey("dbo.Bordados", t => t.BordadoId)
                .ForeignKey("dbo.Linha", t => t.LinhaCodigo)
                .Index(t => t.BordadoId)
                .Index(t => t.LinhaCodigo);
            
            CreateTable(
                "dbo.Bordados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Arquivo = c.String(nullable: false, maxLength: 50, unicode: false),
                        Caminho = c.String(maxLength: 255, unicode: false),
                        Descricao = c.String(maxLength: 50, unicode: false),
                        Disquete = c.String(maxLength: 12, unicode: false),
                        Bastidor = c.String(maxLength: 12, unicode: false),
                        Grupo_Id = c.Int(nullable: false),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pontos = c.Int(nullable: false),
                        Cores = c.Int(nullable: false),
                        Largura = c.Int(nullable: false),
                        Altura = c.Int(nullable: false),
                        Metragem = c.Int(nullable: false),
                        Aprovado = c.Boolean(nullable: false),
                        Imagem = c.Binary(),
                        ObsPublica = c.String(maxLength: 1024, unicode: false),
                        ObsPrivada = c.String(maxLength: 1024, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Linha",
                c => new
                    {
                        Codigo = c.String(nullable: false, maxLength: 100, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 30, unicode: false),
                        MaterialNome = c.String(maxLength: 20, unicode: false),
                        MaterialFabricante = c.String(maxLength: 20, unicode: false),
                        MaterialTipo = c.String(maxLength: 20, unicode: false),
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
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120, unicode: false),
                        Contato_Funcao = c.String(maxLength: 20, unicode: false),
                        Contato_Nome = c.String(maxLength: 50, unicode: false),
                        Cgc_Cpf = c.String(maxLength: 20, unicode: false),
                        Inscr_Estadual = c.String(maxLength: 20, unicode: false),
                        Endereco = c.String(maxLength: 100, unicode: false),
                        Cidade = c.String(maxLength: 20, unicode: false),
                        Estado = c.String(maxLength: 2, unicode: false),
                        Cep = c.String(maxLength: 9, unicode: false),
                        Telefone1 = c.String(maxLength: 15, unicode: false),
                        Telefone2 = c.String(maxLength: 15, unicode: false),
                        Telefone3 = c.String(maxLength: 15, unicode: false),
                        Email = c.String(maxLength: 60, unicode: false),
                        Obs = c.String(maxLength: 512, unicode: false),
                        Preco_Base = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        EnderecoId = c.Guid(nullable: false),
                        Logradouro = c.String(nullable: false, maxLength: 150, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 100, unicode: false),
                        Complemento = c.String(nullable: false, maxLength: 100, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 50, unicode: false),
                        Estado = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cep = c.String(nullable: false, maxLength: 8, unicode: false),
                    })
                .PrimaryKey(t => t.EnderecoId);
            
            CreateTable(
                "dbo.Fornecedores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 120, unicode: false),
                        Contato_Funcao = c.String(maxLength: 20, unicode: false),
                        Contato_Nome = c.String(maxLength: 50, unicode: false),
                        Cgc_Cpf = c.String(maxLength: 20, unicode: false),
                        Inscr_Estadual = c.String(maxLength: 20, unicode: false),
                        Endereco = c.String(maxLength: 100, unicode: false),
                        Cidade = c.String(maxLength: 20, unicode: false),
                        Estado = c.String(maxLength: 2, unicode: false),
                        Cep = c.String(maxLength: 9, unicode: false),
                        Telefone1 = c.String(maxLength: 15, unicode: false),
                        Telefone2 = c.String(maxLength: 15, unicode: false),
                        Telefone3 = c.String(maxLength: 15, unicode: false),
                        Email = c.String(maxLength: 60, unicode: false),
                        Obs = c.String(maxLength: 512, unicode: false),
                        CreatedDate = c.DateTime(nullable: false, precision: 0),
                        ModifiedDate = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        PessoaId = c.Guid(nullable: false),
                        DataCadastro = c.DateTime(nullable: false, precision: 0),
                        Ativo = c.Boolean(nullable: false),
                        NegarCredito = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PessoaId)
                .ForeignKey("dbo.PessoaFisica", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.PessoaFisica",
                c => new
                    {
                        PessoaFisicaId = c.Guid(nullable: false),
                        Nome = c.String(maxLength: 100, unicode: false),
                        Cpf = c.String(maxLength: 11, unicode: false),
                        PessoaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.PessoaFisicaId);
            
            CreateTable(
                "dbo.PessoaJuridica",
                c => new
                    {
                        PessoaJuridicaId = c.Guid(nullable: false),
                        Cnpj = c.String(maxLength: 14, unicode: false),
                        RazaoSocial = c.String(maxLength: 100, unicode: false),
                        PessoaId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.PessoaJuridicaId)
                .ForeignKey("dbo.Pessoa", t => t.PessoaId)
                .Index(t => t.PessoaId);
            
            CreateTable(
                "dbo.PessoaFisicaEndereco",
                c => new
                    {
                        PessoaFisicaId = c.Guid(nullable: false),
                        EnderecoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.PessoaFisicaId, t.EnderecoId })
                .ForeignKey("dbo.PessoaFisica", t => t.PessoaFisicaId)
                .ForeignKey("dbo.Endereco", t => t.EnderecoId)
                .Index(t => t.PessoaFisicaId)
                .Index(t => t.EnderecoId);
            
            CreateTable(
                "dbo.PessoaJuridicaEndereco",
                c => new
                    {
                        PessoaJuridicaId = c.Guid(nullable: false),
                        EnderecoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.PessoaJuridicaId, t.EnderecoId })
                .ForeignKey("dbo.PessoaJuridica", t => t.PessoaJuridicaId)
                .ForeignKey("dbo.Endereco", t => t.EnderecoId)
                .Index(t => t.PessoaJuridicaId)
                .Index(t => t.EnderecoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PessoaJuridica", "PessoaId", "dbo.Pessoa");
            DropForeignKey("dbo.PessoaJuridicaEndereco", "EnderecoId", "dbo.Endereco");
            DropForeignKey("dbo.PessoaJuridicaEndereco", "PessoaJuridicaId", "dbo.PessoaJuridica");
            DropForeignKey("dbo.Pessoa", "PessoaId", "dbo.PessoaFisica");
            DropForeignKey("dbo.PessoaFisicaEndereco", "EnderecoId", "dbo.Endereco");
            DropForeignKey("dbo.PessoaFisicaEndereco", "PessoaFisicaId", "dbo.PessoaFisica");
            DropForeignKey("dbo.BordadoLinha", "LinhaCodigo", "dbo.Linha");
            DropForeignKey("dbo.BordadoLinha", "BordadoId", "dbo.Bordados");
            DropForeignKey("dbo.Transaction", "UserID", "dbo.User");
            DropForeignKey("dbo.Transaction", "CustomerID", "dbo.Account");
            DropForeignKey("dbo.Account", "CustomerID", "dbo.Customer");
            DropIndex("dbo.PessoaJuridicaEndereco", new[] { "EnderecoId" });
            DropIndex("dbo.PessoaJuridicaEndereco", new[] { "PessoaJuridicaId" });
            DropIndex("dbo.PessoaFisicaEndereco", new[] { "EnderecoId" });
            DropIndex("dbo.PessoaFisicaEndereco", new[] { "PessoaFisicaId" });
            DropIndex("dbo.PessoaJuridica", new[] { "PessoaId" });
            DropIndex("dbo.Pessoa", new[] { "PessoaId" });
            DropIndex("dbo.BordadoLinha", new[] { "LinhaCodigo" });
            DropIndex("dbo.BordadoLinha", new[] { "BordadoId" });
            DropIndex("dbo.Transaction", new[] { "UserID" });
            DropIndex("dbo.Transaction", new[] { "CustomerID" });
            DropIndex("dbo.Account", new[] { "CustomerID" });
            DropTable("dbo.PessoaJuridicaEndereco");
            DropTable("dbo.PessoaFisicaEndereco");
            DropTable("dbo.PessoaJuridica");
            DropTable("dbo.PessoaFisica");
            DropTable("dbo.Pessoa");
            DropTable("dbo.Fornecedores");
            DropTable("dbo.Endereco");
            DropTable("dbo.Cliente");
            DropTable("dbo.Linha");
            DropTable("dbo.Bordados");
            DropTable("dbo.BordadoLinha");
            DropTable("dbo.ApplicationSetting");
            DropTable("dbo.User");
            DropTable("dbo.Transaction");
            DropTable("dbo.Customer");
            DropTable("dbo.Account");
        }
    }
}
