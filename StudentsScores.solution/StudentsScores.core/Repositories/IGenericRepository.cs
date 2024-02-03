using StudentsScores.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsScores.core.Repositories
{
    public interface IGenericRepository<T>where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}
