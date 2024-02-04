using StudentsScores.core.Entities;

namespace StudentsScores.APIS.DTOS
{
    public class StudentDto
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public IEnumerable<ScoreSubject> Scores { get; set; }
    }
}
