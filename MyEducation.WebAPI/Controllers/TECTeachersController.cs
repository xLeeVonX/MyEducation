namespace MyEducation.WebAPI.Controllers
{
    [ApiController]
    [Route("tec/teachers")]
    public class TECTeachersController : ControllerBase
    {
        private readonly TECTeacherService _teacherService;

        public TECTeachersController(TECTeacherService teacherService)
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
