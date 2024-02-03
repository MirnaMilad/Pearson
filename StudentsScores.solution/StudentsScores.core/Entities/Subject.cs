using StudentsScores.core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsScores.core.Entities
{
    public class Subject :BaseEntity
    {
        public SubjectEnum Value { get; set; }
    }
}
