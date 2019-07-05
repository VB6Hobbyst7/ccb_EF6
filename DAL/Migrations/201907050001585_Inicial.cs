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
                "dbo.Transaction",
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
                .ForeignKey("dbo.Account", t => t.CustomerID)
                .ForeignKey("dbo.User", t => t.UserID)
                .Index(t => t.CustomerID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.User",
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
                "dbo.ApplicationSetting",
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
                "dbo.BordadoLinha",
                c => new
                    {
                        BordadoId = c.Int(nullable: false),
                        LinhaCodigo = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
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
                "dbo.Linha",
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
                "dbo.cidade",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 30, storeType: "nvarchar"),
                        ativo = c.Boolean(nullable: false),
                        id_estado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.estado", t => t.id_estado)
                .Index(t => t.id_estado);
            
            CreateTable(
                "dbo.estado",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 30, storeType: "nvarchar"),
                        uf = c.String(nullable: false, maxLength: 2, storeType: "nvarchar"),
                        ativo = c.Boolean(nullable: false),
                        id_pais = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.pais", t => t.id_pais)
                .Index(t => t.id_pais);
            
            CreateTable(
                "dbo.pais",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 30, storeType: "nvarchar"),
                        codigo = c.String(nullable: false, maxLength: 3, storeType: "nvarchar"),
                        ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Cliente",
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
                "dbo.Enderecos",
                c => new
                    {
                        EnderecoId = c.Int(nullable: false),
                        Logradouro = c.String(nullable: false, maxLength: 200, storeType: "nvarchar"),
                        Complemento = c.String(unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        Bairro = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Cidade = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        Estado = c.String(nullable: false, maxLength: 2, storeType: "nvarchar"),
                        Cep = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.EnderecoId)
                .ForeignKey("dbo.Pessoas", t => t.EnderecoId)
                .Index(t => t.EnderecoId);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataCadastro = c.DateTime(nullable: false, precision: 0),
                        TipoPessoa = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PessoasFisicas",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 150, storeType: "nvarchar"),
                        CPF = c.String(nullable: false, maxLength: 11, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.PessoasJuridicas",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 150, storeType: "nvarchar"),
                        CNPJ = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoas", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.entrada_produto",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        numero = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        data = c.DateTime(nullable: false, precision: 0),
                        quant = c.Int(nullable: false),
                        id_produto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.produto", t => t.id_produto)
                .Index(t => t.id_produto);
            
            CreateTable(
                "dbo.produto",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        codigo = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        nome = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        preco_custo = c.Decimal(nullable: false, precision: 7, scale: 2),
                        preco_venda = c.Decimal(nullable: false, precision: 7, scale: 2),
                        quant_estoque = c.Int(nullable: false),
                        id_unidade_medida = c.Int(nullable: false),
                        id_grupo = c.Int(nullable: false),
                        id_marca = c.Int(nullable: false),
                        id_fornecedor = c.Int(nullable: false),
                        id_local_armazenamento = c.Int(nullable: false),
                        ativo = c.Boolean(nullable: false),
                        imagem = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.fornecedor", t => t.id_fornecedor)
                .ForeignKey("dbo.grupo_produto", t => t.id_grupo)
                .ForeignKey("dbo.local_armazenamento", t => t.id_local_armazenamento)
                .ForeignKey("dbo.marca_produto", t => t.id_marca)
                .ForeignKey("dbo.unidade_medida", t => t.id_unidade_medida)
                .Index(t => t.id_unidade_medida)
                .Index(t => t.id_grupo)
                .Index(t => t.id_marca)
                .Index(t => t.id_fornecedor)
                .Index(t => t.id_local_armazenamento);
            
            CreateTable(
                "dbo.fornecedor",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 60, storeType: "nvarchar"),
                        razao_social = c.String(maxLength: 100, storeType: "nvarchar"),
                        num_documento = c.String(maxLength: 20, storeType: "nvarchar"),
                        tipo = c.Int(nullable: false),
                        telefone = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        contato = c.String(nullable: false, maxLength: 60, storeType: "nvarchar"),
                        logradouro = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        numero = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        complemento = c.String(maxLength: 100, storeType: "nvarchar"),
                        cep = c.String(maxLength: 10, storeType: "nvarchar"),
                        id_pais = c.Int(nullable: false),
                        id_estado = c.Int(nullable: false),
                        id_cidade = c.Int(nullable: false),
                        ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.cidade", t => t.id_cidade)
                .ForeignKey("dbo.estado", t => t.id_estado)
                .ForeignKey("dbo.pais", t => t.id_pais)
                .Index(t => t.id_pais)
                .Index(t => t.id_estado)
                .Index(t => t.id_cidade);
            
            CreateTable(
                "dbo.grupo_produto",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.local_armazenamento",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.marca_produto",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.unidade_medida",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 30, storeType: "nvarchar"),
                        sigla = c.String(nullable: false, maxLength: 3, storeType: "nvarchar"),
                        ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.inventario_estoque",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        data = c.DateTime(nullable: false, precision: 0),
                        motivo = c.String(maxLength: 100, storeType: "nvarchar"),
                        quant_estoque = c.Int(nullable: false),
                        quant_inventario = c.Int(nullable: false),
                        id_produto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.produto", t => t.id_produto)
                .Index(t => t.id_produto);
            
            CreateTable(
                "dbo.perfil",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.usuario",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        login = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        senha = c.String(nullable: false, maxLength: 32, storeType: "nvarchar"),
                        nome = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        email = c.String(nullable: false, maxLength: 150, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.saida_produto",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        numero = c.String(nullable: false, maxLength: 10, storeType: "nvarchar"),
                        data = c.DateTime(nullable: false, precision: 0),
                        quant = c.Int(nullable: false),
                        id_produto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.produto", t => t.id_produto)
                .Index(t => t.id_produto);
            
            CreateTable(
                "dbo.perfil_usuario",
                c => new
                    {
                        id_perfil = c.Int(nullable: false),
                        id_usuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.id_perfil, t.id_usuario })
                .ForeignKey("dbo.perfil", t => t.id_perfil)
                .ForeignKey("dbo.usuario", t => t.id_usuario)
                .Index(t => t.id_perfil)
                .Index(t => t.id_usuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.saida_produto", "id_produto", "dbo.produto");
            DropForeignKey("dbo.perfil_usuario", "id_usuario", "dbo.usuario");
            DropForeignKey("dbo.perfil_usuario", "id_perfil", "dbo.perfil");
            DropForeignKey("dbo.inventario_estoque", "id_produto", "dbo.produto");
            DropForeignKey("dbo.entrada_produto", "id_produto", "dbo.produto");
            DropForeignKey("dbo.produto", "id_unidade_medida", "dbo.unidade_medida");
            DropForeignKey("dbo.produto", "id_marca", "dbo.marca_produto");
            DropForeignKey("dbo.produto", "id_local_armazenamento", "dbo.local_armazenamento");
            DropForeignKey("dbo.produto", "id_grupo", "dbo.grupo_produto");
            DropForeignKey("dbo.produto", "id_fornecedor", "dbo.fornecedor");
            DropForeignKey("dbo.fornecedor", "id_pais", "dbo.pais");
            DropForeignKey("dbo.fornecedor", "id_estado", "dbo.estado");
            DropForeignKey("dbo.fornecedor", "id_cidade", "dbo.cidade");
            DropForeignKey("dbo.PessoasJuridicas", "Id", "dbo.Pessoas");
            DropForeignKey("dbo.PessoasFisicas", "Id", "dbo.Pessoas");
            DropForeignKey("dbo.Enderecos", "EnderecoId", "dbo.Pessoas");
            DropForeignKey("dbo.cidade", "id_estado", "dbo.estado");
            DropForeignKey("dbo.estado", "id_pais", "dbo.pais");
            DropForeignKey("dbo.BordadoLinha", "LinhaCodigo", "dbo.Linha");
            DropForeignKey("dbo.BordadoLinha", "BordadoId", "dbo.Bordados");
            DropForeignKey("dbo.Transaction", "UserID", "dbo.User");
            DropForeignKey("dbo.Transaction", "CustomerID", "dbo.Account");
            DropForeignKey("dbo.Account", "CustomerID", "dbo.Customer");
            DropIndex("dbo.perfil_usuario", new[] { "id_usuario" });
            DropIndex("dbo.perfil_usuario", new[] { "id_perfil" });
            DropIndex("dbo.saida_produto", new[] { "id_produto" });
            DropIndex("dbo.inventario_estoque", new[] { "id_produto" });
            DropIndex("dbo.fornecedor", new[] { "id_cidade" });
            DropIndex("dbo.fornecedor", new[] { "id_estado" });
            DropIndex("dbo.fornecedor", new[] { "id_pais" });
            DropIndex("dbo.produto", new[] { "id_local_armazenamento" });
            DropIndex("dbo.produto", new[] { "id_fornecedor" });
            DropIndex("dbo.produto", new[] { "id_marca" });
            DropIndex("dbo.produto", new[] { "id_grupo" });
            DropIndex("dbo.produto", new[] { "id_unidade_medida" });
            DropIndex("dbo.entrada_produto", new[] { "id_produto" });
            DropIndex("dbo.PessoasJuridicas", new[] { "Id" });
            DropIndex("dbo.PessoasFisicas", new[] { "Id" });
            DropIndex("dbo.Enderecos", new[] { "EnderecoId" });
            DropIndex("dbo.estado", new[] { "id_pais" });
            DropIndex("dbo.cidade", new[] { "id_estado" });
            DropIndex("dbo.BordadoLinha", new[] { "LinhaCodigo" });
            DropIndex("dbo.BordadoLinha", new[] { "BordadoId" });
            DropIndex("dbo.Transaction", new[] { "UserID" });
            DropIndex("dbo.Transaction", new[] { "CustomerID" });
            DropIndex("dbo.Account", new[] { "CustomerID" });
            DropTable("dbo.perfil_usuario");
            DropTable("dbo.saida_produto");
            DropTable("dbo.usuario");
            DropTable("dbo.perfil");
            DropTable("dbo.inventario_estoque");
            DropTable("dbo.unidade_medida");
            DropTable("dbo.marca_produto");
            DropTable("dbo.local_armazenamento");
            DropTable("dbo.grupo_produto");
            DropTable("dbo.fornecedor");
            DropTable("dbo.produto");
            DropTable("dbo.entrada_produto");
            DropTable("dbo.PessoasJuridicas");
            DropTable("dbo.PessoasFisicas");
            DropTable("dbo.Pessoas");
            DropTable("dbo.Enderecos");
            DropTable("dbo.Cliente");
            DropTable("dbo.pais");
            DropTable("dbo.estado");
            DropTable("dbo.cidade");
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
