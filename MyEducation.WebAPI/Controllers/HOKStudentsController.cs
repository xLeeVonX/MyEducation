using MyEducation.WebAPI.Application.Services;

namespace MyEducation.WebAPI.Controllers
{
    [ApiController]
    [Route("hok/students")]
    public class HOKStudentsController : ControllerBase
    {
        private readonly StudentService _studentService;

        public HOKStudentsController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            var created = _studentService.CreateStudent(student);
            return Ok(created);
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
