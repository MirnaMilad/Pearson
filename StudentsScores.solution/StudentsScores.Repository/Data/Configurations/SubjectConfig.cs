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
    internal class SubjectConfig : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.Property(M => M.Value)
              .HasConversion(
          v => v.ToString(),
          v => (SubjectEnum)Enum.Parse(typeof(SubjectEnum), v)
      );

            builder.HasData(
       new Subject { Id = 1, Value = SubjectEnum.English },
       new Subject { Id = 2, Value = SubjectEnum.Maths },
       new Subject { Id = 3, Value = SubjectEnum.Science }
   );
        }
    }
}
