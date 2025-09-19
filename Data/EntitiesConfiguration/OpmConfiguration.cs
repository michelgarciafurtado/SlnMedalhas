using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EntitiesConfiguration
{
    public class OpmConfiguration : IEntityTypeConfiguration<Opm>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Opm> builder)
        {
            builder.ToTable("Tbl_Opm");
            builder.HasKey(o => o.CodOpm);

            builder.HasData(
                new Opm("607070000", "7.bpm/i", "607000000"),
                new Opm("607500000", "50.bpm/i", "607000000"),
                new Opm("607400000", "40.bpm/i", "607000000")
                );
        }
    }
}
