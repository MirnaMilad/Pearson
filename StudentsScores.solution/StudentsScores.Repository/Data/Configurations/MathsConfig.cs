using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentsScores.core.Entities;
using StudentsScores.core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StudentsScores.Repository.Data.Configurations
{
    internal class MathsConfig : IEntityTypeConfiguration<Maths>
    {
        public void Configure(EntityTypeBuilder<Maths> builder)
        {
            builder.Property(M => M.Value)
                .HasConversion(
            v => v.ToString(),
            v => (MathsEnum)Enum.Parse(typeof(MathsEnum), v)
        );

            builder.HasData(
        new Maths { Id = 1, Value = MathsEnum.A },
        new Maths { Id = 2, Value = MathsEnum.B },
        new Maths { Id = 3, Value = MathsEnum.C },
        new Maths { Id = 4, Value = MathsEnum.D },
        new Maths { Id = 5, Value = MathsEnum.E },
        new Maths { Id = 6, Value = MathsEnum.F }
    );
        }
    }
}
