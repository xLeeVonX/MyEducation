namespace MyEducation.WebAPI.Application.Services
{
    public class TECStudentService
    {
        private readonly ITECStudentRepository _studentRepository;

        public TECStudentService(ITECStudentRepository studentFactory)
        {
            _studentRepository = studentFactory;
        }

        //  CREATE
        public Student CreateStudent(Student student)
        {
            return _studentRepository.Add(student);
        }

        //  READ
        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }

        //  UPDATE
        public Student UpdateStudent(Student student)
        {
            return _studentRepository.Update(student);
        }

        //  DELETE
        public void DeleteStudent(int id)
        {
            _studentRepository.Delete(id);
        }
    }
}
