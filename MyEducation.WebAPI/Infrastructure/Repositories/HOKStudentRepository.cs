namespace MyEducation.WebAPI.Infrastructure.Repositories
{
    public class HOKStudentRepository : IStudentRepository
    {
        private readonly HOKcontext _context;

        public HOKStudentRepository(HOKcontext context)
        {
            _context = context;
        }

        public Student GetById(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null)
                throw new Exception("Student not found!");

            return student;
        }

        public Student Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return student;
        }

        public void Delete(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null)
                throw new Exception("Student not found!");

            _context.Students.Remove(student);
            _context.SaveChanges();
        }
    }
}
