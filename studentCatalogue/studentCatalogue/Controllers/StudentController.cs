using Microsoft.AspNetCore.Mvc;


namespace studentCatalogue.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentDB _db;

        public StudentController(StudentDB db)
        {
            _db = db;
        }

        [HttpGet(Name = "GetStudent")]
        public IActionResult GetStudents()
        {
            var students = _db.Students;
            return Ok(students);
        }
    }
}
