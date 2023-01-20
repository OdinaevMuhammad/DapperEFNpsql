using Domain.Dto;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController
    {
        private  StudentService _studentsService;

        public StudentController(StudentService studentService)
        {
            _studentsService = studentService;
        }


        [HttpGet("GetWithDapper")]
        public List<StudentDto> GetStudents()
        {
            return _studentsService.GetStudents();
        }
    
        [HttpGet("GetWithoutDapper")]
        public List<StudentDto> GetStudentsWithoutDapper()
        {
            return _studentsService.GetStudentsWithoutDapper();
        }
        
        [HttpGet("GetWithEF")]
        public List<StudentDto> GetStudentWithEF()
        {
            return _studentsService.GetStudentWithEnt();
        }

        }
}

