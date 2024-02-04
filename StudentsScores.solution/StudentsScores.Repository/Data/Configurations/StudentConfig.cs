using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentsScores.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsScores.Repository.Data.Configurations
{
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasMany(S => S.Scores)
                 .WithOne()
                 .HasForeignKey(S => S.StudentId);

            builder.HasOne(S => S.Subject)
                .WithMany()
                .HasForeignKey(S => S.SubjectId);
        }
    }
}
