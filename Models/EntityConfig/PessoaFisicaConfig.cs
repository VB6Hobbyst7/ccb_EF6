using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Models.EntityConfig
{
    public class PessoaFisicaConfig : EntityTypeConfiguration<PessoaFisica>
    {
        public PessoaFisicaConfig()
        {
            HasKey(pf => pf.Id);
            Property(pf => pf.Nome)
                .IsRequired()
                .HasMaxLength(150);
            Property(pf => pf.CPF)
                .IsRequired()
                .HasMaxLength(11);

                   //.MapToStoredProcedures(s => s.Insert(i => i.HasName("adicionar_endereco_pessoaFisica")
                   //              .LeftKeyParameter(p => p.Id, "pessoaFisica_Id")
                   //              .RightKeyParameter(t => t.Id, "endereco_Id"))
                   //.Delete(d => d.HasName("remover_endereco_pessoaFisica")
                   //              .LeftKeyParameter(p => p.Id, "pessoaFisica_Id")
                   //              .RightKeyParameter(t => t.Id, "endereco_Id")));

            ToTable("PessoasFisicas");
        }
    }
}