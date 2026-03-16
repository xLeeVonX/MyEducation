namespace MyEducation.WebAPI.Infrastructure.Repositories
{
    public class TECStudentRepository : IStudentRepository
    {
        private readonly TECcontext _context;

        public TECStudentRepository(TECcontext context)
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
