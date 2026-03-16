namespace MyEducation.WebAPI.Application.Services
{
    public class TECTeacherService
    {
        private readonly ITECTeacherRepository _teacherRepository;

        public TECTeacherService(ITECTeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        //  CREATE
        public Teacher CreateTeacher(Teacher teacher)
        {
            return _teacherRepository.Add(teacher);
        }

        //  READ
        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _teacherRepository.GetAll();
        }

        //  UPDATE
        public Teacher UpdateTeacher(Teacher teacher)
        {
            return _teacherRepository.Update(teacher);
        }

        //  DELETE
        public void DeleteTeacher(int id)
        {
            _teacherRepository.Delete(id);
        }
    }
}
