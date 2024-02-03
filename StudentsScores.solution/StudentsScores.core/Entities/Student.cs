using StudentsScores.core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsScores.core.Entities
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public ICollection<ScoreSubject> Scores { get; set; }

    }
}
