using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsScores.APIS.DTOS;
using StudentsScores.core.Entities;
using StudentsScores.core.Repositories;

namespace StudentsScores.APIS.Controllers
{
    public class StudentsController : ApiBaseController
    {
        private readonly IGenericRepository<Student> _studentRepo;
        private readonly IMapper _mapper;

        public StudentsController(IGenericRepository<Student> StudentRepo , IMapper mapper)
        {
            _studentRepo = StudentRepo;
            _mapper = mapper;
        }
        //Get All Students
        //BaseUrl/api/Students
        [HttpGet]
        public async Task<ActionResult> GetStudents()
        {
            var Students = await _studentRepo.GetAllAsync();
            var MappedStudents = _mapper.Map<IEnumerable<Student> , IEnumerable<StudentDto>>(Students);
            return Ok(MappedStudents);
        }
    }
}
