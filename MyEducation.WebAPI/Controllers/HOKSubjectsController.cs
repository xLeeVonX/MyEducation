using MyEducation.WebAPI.Application.Services;

namespace MyEducation.WebAPI.Controllers
{
    [ApiController]
    [Route("hok/subjects")]
    public class HOKSubjectsController : ControllerBase
    {
        private readonly SubjectService _subjectService;

        public HOKSubjectsController(SubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpPost]
        public IActionResult Create(Subject subject)
        {
            var created = _subjectService.CreateSubject(subject);
            return Ok(created);
        }

        [HttpPut]
        public IActionResult Update(Subject subject)
        {
            var updated = _subjectService.UpdateSubject(subject);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _subjectService.DeleteSubject(id);
            return NoContent();
        }
    }
}
