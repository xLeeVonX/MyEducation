namespace MyEducation.WebAPI.Infrastructure.Repositories
{
    public class TECTeacherRepository : ITECTeacherRepository
    {
        private readonly TECcontext _context;

        public TECTeacherRepository(TECcontext context)
        {
            _context = context;
        }

        public Teacher GetById(int id)
        {
            var teacher = _context.Teachers.Find(id);

            if (teacher == null)
                throw new Exception("Student not found!");

            return teacher;
        }
        
        public Teacher Add(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            return teacher;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }

        public Teacher Update(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
            _context.SaveChanges();
            return teacher;
        }
        
        public void Delete(int id)
        {
            var teacher = _context.Teachers.Find(id);

            if (teacher == null)
                throw new Exception("Student not found!");

            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
        }
    }
}
