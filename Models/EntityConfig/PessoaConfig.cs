using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Models.EntityConfig
{
    public class PessoaConfig : EntityTypeConfiguration<Pessoa>
    {
        public PessoaConfig()
        {
            HasKey(p => p.Id);
            Property(p => p.DataCadastro)
                .IsRequired();
            Property(p => p.TipoPessoa)
                .IsRequired();

            HasOptional(p => p.PessoaFisica)
                .WithRequired(p => p.Pessoa);
            HasOptional(p => p.PessoaJuridica)
                .WithRequired(p => p.Pessoa);

            ToTable("Pessoas");
        }
    }
}