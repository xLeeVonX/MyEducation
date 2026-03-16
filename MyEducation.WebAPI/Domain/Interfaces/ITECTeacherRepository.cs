namespace MyEducation.WebAPI.Domain.Interfaces;


public interface ITECTeacherRepository
{
    Teacher GetById(int id);

    Teacher Add(Teacher teacher);

    IEnumerable<Teacher> GetAll();

    Teacher Update(Teacher teacher);

    void Delete(int id);
}
