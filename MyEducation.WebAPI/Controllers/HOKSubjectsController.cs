namespace MyEducation.WebAPI.Controllers
{
    [ApiController]
    [Route("hok/subjects")]
    public class HOKSubjectsController : ControllerBase
    {
        private readonly HOKSubjectService _subjectService;

        public HOKSubjectsController(HOKSubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        [HttpPost]
        public IActionResult Create(Subject subject)
        {
            var created = _subjectService.CreateSubject(subject);
            return Ok(created);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var subjects = _subjectService.GetAllSubjects();
            return Ok(subjects);
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
