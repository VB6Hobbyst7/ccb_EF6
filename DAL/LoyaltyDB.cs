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

            modelBuilder.Properties()
               .Where(mo => mo.Name == mo.ReflectedType.Name + "Id")
               .Configure(mo => mo.IsKey());

            base.OnModelCreating(modelBuilder);
        }
    }

}