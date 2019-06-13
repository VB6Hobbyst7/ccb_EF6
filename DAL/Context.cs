using Models.EntityConfig;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.Entity;

namespace Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CCB_Context : DbContext
    {
        public CCB_Context() : base(GetConnectionString("ccb_ef6", "LocalDB"))
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public static string GetConnectionString(string dbName, string dbConnectionStringName)
        {
            var connString = ConfigurationManager.ConnectionStrings[dbConnectionStringName].ConnectionString.ToString();

            return String.Format(connString, dbName);
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<PessoaFisica> PessoaFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridicas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        //public DbSet<Foto> Fotos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new PessoaConfig());
            modelBuilder.Configurations.Add(new PessoaFisicaConfig());
            modelBuilder.Configurations.Add(new PessoaJuridicaConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new FotoConfig());

            modelBuilder.Properties()
                .Where(mo => mo.Name == mo.ReflectedType.Name + "Id")
                .Configure(mo => mo.IsKey());


            base.OnModelCreating(modelBuilder);
        }
    }
}