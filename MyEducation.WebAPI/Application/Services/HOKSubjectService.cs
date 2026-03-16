namespace MyEducation.WebAPI.Application.Services
{
    public class HOKSubjectService
    {
        private readonly IHOKSubjectRepository _subjectRepository;

        public HOKSubjectService(IHOKSubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        //  CREATE
        public Subject CreateSubject(Subject subject)
        {
            return _subjectRepository.Add(subject);
        }

        //  READ
        public IEnumerable<Subject> GetAllSubjects()
        {
            return _subjectRepository.GetAll();
        }

        //  UPDATE
        public Subject UpdateSubject(Subject subject)
        {
            return _subjectRepository.Update(subject);
        }

        //  DELETE
        public void DeleteSubject(int id)
        {
            _subjectRepository.Delete(id);
        }
    }
}
