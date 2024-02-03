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
    internal class ScoreConfig : IEntityTypeConfiguration<ScoreSubject>
    {
        public void Configure(EntityTypeBuilder<ScoreSubject> builder)
        {
            builder.HasOne(S => S.Student)
                .WithMany()
                .HasForeignKey(S => S.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(S => S.LearningObjective)
                .HasConversion<string>();
        }
    }
}
