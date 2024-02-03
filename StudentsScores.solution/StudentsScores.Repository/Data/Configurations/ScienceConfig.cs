using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentsScores.core.Entities;
using StudentsScores.core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsScores.Repository.Data.Configurations
{
    internal class ScienceConfig : IEntityTypeConfiguration<Science>
    {
        public void Configure(EntityTypeBuilder<Science> builder)
        {

            builder.Property(M => M.Value)
                .HasConversion(
            v => v.ToString(),
            v => (ScienceEnum)Enum.Parse(typeof(ScienceEnum), v)
        );

            builder.HasData(
       new Science { Id = 1, Value = ScienceEnum.Excellent },
       new Science { Id = 2, Value = ScienceEnum.Good },
       new Science { Id = 3, Value = ScienceEnum.Average },
       new Science { Id = 4, Value = ScienceEnum.Poor },
       new Science { Id = 5, Value = ScienceEnum.VeryPoor }
   );
        }
    }
}
