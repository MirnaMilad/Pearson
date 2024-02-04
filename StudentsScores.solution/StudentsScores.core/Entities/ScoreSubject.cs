using StudentsScores.core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentsScores.core.Entities
{
    public class ScoreSubject:BaseEntity
    {
        public int StudentId { get; set; }
        private Student _student;
        private Student Student
        {
            get => _student;
            set
            {

                _student = value;
                SetScoreEnum();
            }
        }
        public string LearningObjective { get; set; }
        public string Score { get; set; }

        private English English { get; set; }
        private Maths Maths { get; set; }
        private Science Science { get; set; }

        private void SetScoreEnum()
        {
            switch (Student.Subject.Value)
            {
                case SubjectEnum.English:
                    Score = English.Value.ToString();
                    break;
                case SubjectEnum.Maths:
                    Score = Maths.Value.ToString();
                    break;
                case SubjectEnum.Science:
                    Score = Science.Value.ToString();
                    break;

            }
        }


    }

}
