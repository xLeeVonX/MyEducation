namespace MyEducation.WebAPI.Application.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
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
