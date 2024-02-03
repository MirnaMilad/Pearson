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
    internal class EnglishConfig : IEntityTypeConfiguration<English>
    {
        public void Configure(EntityTypeBuilder<English> builder)
        {
            builder.Property(E => E.Value)
                .HasConversion(
            v => v.ToString(),   
            v => (EnglishEnum)Enum.Parse(typeof(EnglishEnum), v)  
        );

            builder.HasData(
       new English { Id = 1, Value = EnglishEnum.one },
       new English { Id = 2, Value = EnglishEnum.two },
       new English { Id = 3, Value = EnglishEnum.three },
       new English { Id = 4, Value = EnglishEnum.four },
       new English { Id = 5, Value = EnglishEnum.five },
       new English { Id = 6, Value = EnglishEnum.six }
   );
        }
    }
}
