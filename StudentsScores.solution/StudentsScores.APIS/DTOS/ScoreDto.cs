using StudentsScores.core.Entities;
using StudentsScores.core.Enums;

namespace StudentsScores.APIS.DTOS
{
    public class ScoreDto
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string LearningObjective { get; set; }
        public string Subject { get; set; }
        public string Score { get; set; }
    }
}
