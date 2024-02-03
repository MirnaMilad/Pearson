using StudentsScores.core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsScores.core.Entities
{
    public class Science:BaseEntity
    {
        public ScienceEnum Value { get; set; }
    }
}
