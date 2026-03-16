namespace MyEducation.WebAPI.Application.Services
{
    public class HOKTeacherService
    {
        private readonly IHOKTeacherRepository _teacherRepository;

        public HOKTeacherService(IHOKTeacherRepository teacherRepository)
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
