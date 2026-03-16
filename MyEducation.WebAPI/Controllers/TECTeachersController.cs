using MyEducation.WebAPI.Application.Services;

namespace MyEducation.WebAPI.Controllers
{
    [ApiController]
    [Route("tec/teachers")]
    public class TECTeachersController : ControllerBase
    {
        private readonly TeacherService _teacherService;

        public TECTeachersController(TeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            var created = _teacherService.CreateTeacher(teacher);
            return Ok(created);
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
