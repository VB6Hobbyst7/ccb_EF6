using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Models.EntityConfig
{
    public class FotoConfig: EntityTypeConfiguration<Foto>
    {
        public FotoConfig()
        {
            HasKey(f => f.Id);

            ToTable("Fotos");

        }
    }
}