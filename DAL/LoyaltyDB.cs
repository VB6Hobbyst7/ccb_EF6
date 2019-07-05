using Models;
using Models.EntityConfig;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL
{

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class LoyaltyDB : DbContext
    {
        //public LoyaltyDB() : base(GetConnectionString("compummc_loyaltydb", "CloudDB"))//Descomentar para usar BD en la nube
        //{
        //    Database.SetInitializer(new LoyaltyDBInitializer());
        //}


        public LoyaltyDB() : base(GetConnectionString("ccb_ef6", "LocalDB"))//Descomentar para usar BD local de pruebas
        {
            Database.SetInitializer(new LoyaltyDBInitializer());
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Bordado> Bordados { get; set; }
        public DbSet<Linha> Linhas { get; set; }
        public DbSet<BordadoLinha> BordadoLinhas { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ApplicationSetting> ApplicationSettings { get; set; }

        public static string GetConnectionString(string dbName, string dbConnectionStringName)
        {
            var connString = ConfigurationManager.ConnectionStrings[dbConnectionStringName].ConnectionString.ToString();

            return String.Format(connString, dbName);
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        //public DbSet<Foto> Fotos { get; set; }

        public DbSet<CidadeModel> Cidades { get; set; }
        public DbSet<EntradaProdutoModel> EntradasProdutos { get; set; }
        public DbSet<EstadoModel> Estados { get; set; }
        public DbSet<FornecedorModel> Fornecedores { get; set; }
        public DbSet<GrupoProdutoModel> GruposProdutos { get; set; }
        public DbSet<InventarioEstoqueModel> InventariosEstoque { get; set; }
        public DbSet<LocalArmazenamentoModel> LocaisArmazenamentos { get; set; }
        public DbSet<MarcaProdutoModel> MarcasProdutos { get; set; }
        public DbSet<PaisModel> Paises { get; set; }
        public DbSet<PerfilModel> PerfisUsuarios { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<SaidaProdutoModel> SaidasProdutos { get; set; }
        public DbSet<UnidadeMedidaModel> UnidadesMedida { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BordadoLinha>().HasKey(sc => new { sc.BordadoId, sc.LinhaCodigo });

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new PessoaConfig());
            modelBuilder.Configurations.Add(new PessoaFisicaConfig());
            modelBuilder.Configurations.Add(new PessoaJuridicaConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            //modelBuilder.Configurations.Add(new FotoConfig());

            modelBuilder.Configurations.Add(new CidadeMap());
            modelBuilder.Configurations.Add(new EntradaProdutoMap());
            modelBuilder.Configurations.Add(new EstadoMap());
            modelBuilder.Configurations.Add(new FornecedorMap());
            modelBuilder.Configurations.Add(new GrupoProdutoMap());
            modelBuilder.Configurations.Add(new InventarioEstoqueMap());
            modelBuilder.Configurations.Add(new LocalArmazenamentoMap());
            modelBuilder.Configurations.Add(new MarcaProdutoMap());
            modelBuilder.Configurations.Add(new PaisMap());
            modelBuilder.Configurations.Add(new PerfilMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new SaidaProdutoMap());
            modelBuilder.Configurations.Add(new UnidadeMedidaMap());
            modelBuilder.Configurations.Add(new UsuarioMap());


            modelBuilder.Properties()
               .Where(mo => mo.Name == mo.ReflectedType.Name + "Id")
               .Configure(mo => mo.IsKey());

            base.OnModelCreating(modelBuilder);
        }
    }

}