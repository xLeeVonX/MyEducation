namespace MyEducation.WebAPI.Controllers
{
    [ApiController]
    [Route("tec/students")]
    public class TECStudentsController : ControllerBase
    {
        private readonly TECStudentService _studentService;

        public TECStudentsController(TECStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            var created = _studentService.CreateStudent(student);
            return Ok(created);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var students = _studentService.GetAllStudents();
            return Ok(students);
        }

        [HttpPut]
        public IActionResult Update(Student student)
        {
            var updated = _studentService.UpdateStudent(student);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _studentService.DeleteStudent(id);
            return NoContent();
        }
    }
}
