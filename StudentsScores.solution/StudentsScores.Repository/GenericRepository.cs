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
            return (IEnumerable<T>)studentsWithSubjectsAndFilteredScores;
        }

        public async Task<IEnumerable<T>> SearchStudentsAsync(string keyword)
        {
            {
                var students = await _dbContext.Students.Include(S=>S.Subject).Where(S =>
                    S.Name.Contains(keyword)).ToListAsync();
                foreach (var student in students)
                {
                    student.Scores = await _dbContext.Scores
                         .Where(score => score.StudentId == student.Id)
                     .ToListAsync();
                }
                return (IEnumerable<T>) students;
            
            }
                    
        }
    }
}
