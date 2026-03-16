namespace MyEducation.WebAPI.Controllers
{
    [ApiController]
    [Route("hok/teachers")]
    public class HOKTeachersController : ControllerBase
    {
        private readonly HOKTeacherService _teacherService;

        public HOKTeachersController(HOKTeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            var created = _teacherService.CreateTeacher(teacher);
            return Ok(created);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var teachers = _teacherService.GetAllTeachers();
            return Ok(teachers);
        }

        [HttpPut]
        public IActionResult Update(Teacher teacher)
        {
            var updated = _teacherService.UpdateTeacher(teacher);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _teacherService.DeleteTeacher(id);
            return NoContent();
        }
    }
}
