namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
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
                .ForeignKey("dbo.Account", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
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
                .ForeignKey("dbo.Bordados", t => t.BordadoId, cascadeDelete: true)
                .ForeignKey("dbo.Linha", t => t.LinhaCodigo, cascadeDelete: true)
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
                "dbo.Course",
                c => new
                    {
                        CourseID = c.Int(nullable: false),
                        Title = c.String(maxLength: 50, storeType: "nvarchar"),
                        Credits = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseID)
                .ForeignKey("dbo.Department", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50, storeType: "nvarchar"),
                        Budget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDate = c.DateTime(nullable: false, precision: 0),
                        InstructorID = c.Int(),
                    })
                .PrimaryKey(t => t.DepartmentID)
                .ForeignKey("dbo.Instructor", t => t.InstructorID)
                .Index(t => t.InstructorID);
            
            CreateTable(
                "dbo.Instructor",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        FirstName = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        HireDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OfficeAssignment",
                c => new
                    {
                        InstructorID = c.Int(nullable: false),
                        Location = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.InstructorID)
                .ForeignKey("dbo.Instructor", t => t.InstructorID)
                .Index(t => t.InstructorID);
            
            CreateTable(
                "dbo.Enrollment",
                c => new
                    {
                        EnrollmentID = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        Grade = c.Int(),
                    })
                .PrimaryKey(t => t.EnrollmentID)
                .ForeignKey("dbo.Course", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.CourseID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        FirstName = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        EnrollmentDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.ID);
            
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
            
            CreateTable(
                "dbo.InstructorCourse",
                c => new
                    {
                        Instructor_ID = c.Int(nullable: false),
                        Course_CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Instructor_ID, t.Course_CourseID })
                .ForeignKey("dbo.Instructor", t => t.Instructor_ID, cascadeDelete: true)
                .ForeignKey("dbo.Course", t => t.Course_CourseID, cascadeDelete: true)
                .Index(t => t.Instructor_ID)
                .Index(t => t.Course_CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollment", "StudentID", "dbo.Student");
            DropForeignKey("dbo.Enrollment", "CourseID", "dbo.Course");
            DropForeignKey("dbo.Course", "DepartmentID", "dbo.Department");
            DropForeignKey("dbo.Department", "InstructorID", "dbo.Instructor");
            DropForeignKey("dbo.OfficeAssignment", "InstructorID", "dbo.Instructor");
            DropForeignKey("dbo.InstructorCourse", "Course_CourseID", "dbo.Course");
            DropForeignKey("dbo.InstructorCourse", "Instructor_ID", "dbo.Instructor");
            DropForeignKey("dbo.BordadoLinha", "LinhaCodigo", "dbo.Linha");
            DropForeignKey("dbo.BordadoLinha", "BordadoId", "dbo.Bordados");
            DropForeignKey("dbo.Transaction", "UserID", "dbo.User");
            DropForeignKey("dbo.Transaction", "CustomerID", "dbo.Account");
            DropForeignKey("dbo.Account", "CustomerID", "dbo.Customer");
            DropIndex("dbo.InstructorCourse", new[] { "Course_CourseID" });
            DropIndex("dbo.InstructorCourse", new[] { "Instructor_ID" });
            DropIndex("dbo.Enrollment", new[] { "StudentID" });
            DropIndex("dbo.Enrollment", new[] { "CourseID" });
            DropIndex("dbo.OfficeAssignment", new[] { "InstructorID" });
            DropIndex("dbo.Department", new[] { "InstructorID" });
            DropIndex("dbo.Course", new[] { "DepartmentID" });
            DropIndex("dbo.BordadoLinha", new[] { "LinhaCodigo" });
            DropIndex("dbo.BordadoLinha", new[] { "BordadoId" });
            DropIndex("dbo.Transaction", new[] { "UserID" });
            DropIndex("dbo.Transaction", new[] { "CustomerID" });
            DropIndex("dbo.Account", new[] { "CustomerID" });
            DropTable("dbo.InstructorCourse");
            DropTable("dbo.Fornecedores");
            DropTable("dbo.Student");
            DropTable("dbo.Enrollment");
            DropTable("dbo.OfficeAssignment");
            DropTable("dbo.Instructor");
            DropTable("dbo.Department");
            DropTable("dbo.Course");
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
