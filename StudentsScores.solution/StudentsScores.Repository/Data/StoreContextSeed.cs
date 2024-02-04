using StudentsScores.APIS.DTOS;
using StudentsScores.core.Entities;
using StudentsScores.core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace StudentsScores.Repository.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext dbContext)
        {
            if (!dbContext.Scores.Any())
            {
                try
                {
                    var filePath = "../StudentsScores.Repository/Data/DataSeed/Scores.json";
                    var ScoresData = File.ReadAllText(filePath);
                    var studentsData = JsonSerializer.Deserialize<List<StudentSeedData>>(ScoresData);
                    if (studentsData?.Count > 0)
                    {
                        foreach (var studentData in studentsData)
                        {
                            var student = new Student
                            {
                                Id = studentData.StudentID,
                                Name = studentData.Name,
                                SubjectId = (int)Enum.Parse<SubjectEnum>(studentData.Subject)
                            };

                            var scoreSubject = new ScoreSubject
                            {
                                StudentId = student.Id,
                                LearningObjective = studentData.LearningObjective,
                                Score = studentData.Score
                            };

                            await dbContext.Set<ScoreSubject>().AddAsync(scoreSubject);
                        }

                        await dbContext.SaveChangesAsync();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error during seeding: {ex.Message}");
                }
            }
                }
        }
}
