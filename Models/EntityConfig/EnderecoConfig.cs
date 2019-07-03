using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Models.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.EnderecoId);
            Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(50);
            Property(e => e.Cidade)
                .IsRequired()
                .HasMaxLength(50);
            Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(2);
            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(200);
            Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(10);
            ToTable("Enderecos");
        }
    }
}