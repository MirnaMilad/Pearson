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
            if (!dbContext.Scores.Any() && !dbContext.Students.Any())
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
                            var existingStudent = dbContext.Students.Find(studentData.StudentID);
                            if (existingStudent == null)
                            {
                                var subjectEnum = Enum.Parse<SubjectEnum>(studentData.Subject);
                                var existingSubject = dbContext.Subjects.FirstOrDefault(s => s.Value == subjectEnum);
                                if (existingSubject == null)
                                {
                                    return;
                                }
                                else
                                {
                                    var existingStudentByName = dbContext.Students.FirstOrDefault(S=>S.Name == studentData.Name);
                                    Student student;
                                    if(existingStudentByName == null)
                                    {
                                        student = new Student
                                        {
                                            // Don't set the Id here, let the database generate it
                                            Name = studentData.Name,
                                            SubjectId = existingSubject.Id
                                        };
                                        await dbContext.Students.AddAsync(student);
                                        await dbContext.SaveChangesAsync();
                                    }
                                    else { 
                                    student = existingStudentByName;
                                    }
                                   
                                    

                                    var scoreSubject = new ScoreSubject
                                    {
                                        StudentId = student.Id, // Now that the student is added, you can use the generated Id
                                        LearningObjective = studentData.LearningObjective,
                                        Score = studentData.Score
                                    };
                                    await dbContext.Scores.AddAsync(scoreSubject);
                                }
                            }
                            else
                            {
                                existingStudent.Name = studentData.Name;
                            }
                        }

                        
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
