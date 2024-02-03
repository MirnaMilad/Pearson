using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsScores.core.Entities;
using StudentsScores.core.Repositories;

namespace StudentsScores.APIS.Controllers
{
    public class StudentsController : ApiBaseController
    {
        private readonly IGenericRepository<Student> _studentRepo;

        public StudentsController(IGenericRepository<Student> StudentRepo)
        {
            _studentRepo = StudentRepo;
        }
        //Get All Students
        //BaseUrl/api/Students
        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var Students = await _studentRepo.GetAllAsync();
            return Ok(Students);
        }
    }
}
