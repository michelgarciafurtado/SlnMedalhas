using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EntitiesConfiguration
{
    public class MedalhaConfiguration : IEntityTypeConfiguration<Medalha>
    {
        public void Configure(EntityTypeBuilder<Medalha> builder)
        {
            builder.ToTable("Tbl_Medalhas");
            builder.HasKey(m => m.IdMedalha);
            builder.Property(m => m.IdMedalha)
                .ValueGeneratedOnAdd();

            builder.HasOne(m => m.Policial)
                .WithMany(p => p.medalhas)
                .HasForeignKey(m => m.Re);
        }
    }
}
