namespace MyEducation.WebAPI.Infrastructure.Repositories
{
    public class HOKSubjectRepository : IHOKSubjectRepository
    {
        private readonly HOKcontext _context;

        public HOKSubjectRepository(HOKcontext context)
        {
            _context = context;
        }
        
        public Subject GetById(int id)
        {
            var subject = _context.Subjects.Find(id);

            if (subject == null)
                throw new Exception("Student not found!");

            return subject;
        }

        public Subject Add(Subject subject)
        {
            _context.Subjects.Add(subject);
            _context.SaveChanges();
            return subject;
        }

        public IEnumerable<Subject> GetAll()
        {
            return _context.Subjects.ToList();
        }

        public Subject Update(Subject subject)
        {
            _context.Subjects.Update(subject);
            _context.SaveChanges();
            return subject;
        }
        
        public void Delete(int id)
        {
            var subject = _context.Subjects.Find(id);

            if (subject == null)
                throw new Exception("Student not found!");

            _context.Subjects.Remove(subject);
            _context.SaveChanges();
        }
    }
}
