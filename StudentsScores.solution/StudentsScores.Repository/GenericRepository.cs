using Microsoft.EntityFrameworkCore;
using StudentsScores.core.Entities;
using StudentsScores.core.Repositories;
using StudentsScores.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace StudentsScores.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StoreContext _dbContext;

        public GenericRepository(StoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            //(IEnumerable<T>) await _dbContext.Students.Include(S => S.Subject).Include(S => S.Scores.Where(score => score.StudentId == S.Id)).ToListAsync();
        var studentsWithSubjectsAndFilteredScores = await _dbContext.Students
    .Include(s => s.Subject)
    .ToListAsync();

        foreach (var student in studentsWithSubjectsAndFilteredScores)
        {
            // Load filtered scores for each student
           student.Scores = await _dbContext.Scores
                .Where(score => score.StudentId == student.Id)
            .ToListAsync();
        }
            return (IEnumerable<T>) studentsWithSubjectsAndFilteredScores;
}
    }
}
