using StudentsScores.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
                    var Scores = JsonSerializer.Deserialize<List<ScoreSubject>>(ScoresData);
                    if (Scores?.Count > 0)
                    {
                        foreach (var score in Scores)
                        {
                            await dbContext.Set<ScoreSubject>().AddAsync(score);
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
