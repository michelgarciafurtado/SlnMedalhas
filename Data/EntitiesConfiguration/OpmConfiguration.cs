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
        }
    }
}
