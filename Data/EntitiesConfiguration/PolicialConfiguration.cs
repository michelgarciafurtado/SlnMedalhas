using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntitiesConfiguration
{
    public class PolicialConfiguration : IEntityTypeConfiguration<Policial>
    {
        public void Configure(EntityTypeBuilder<Policial> builder)
        {
           builder.ToTable("Tbl_Policial");
            builder.HasKey(p => p.Re);
            builder.Property(p => p.Re).IsRequired();

            builder.HasOne(p => p.Opm)
                .WithMany()
                .HasForeignKey(p => p.CodOpm);

        }
    }
}
