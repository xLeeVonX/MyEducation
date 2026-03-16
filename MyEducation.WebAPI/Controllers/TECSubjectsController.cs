using MyEducation.WebAPI.Application.Services;

namespace MyEducation.WebAPI.Controllers
{
    [ApiController]
    [Route("tec/subjects")]
    public class TECSubjectsController : ControllerBase
    {
        private readonly SubjectService _subjectService;

        public TECSubjectsController(SubjectService subjectService)
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
