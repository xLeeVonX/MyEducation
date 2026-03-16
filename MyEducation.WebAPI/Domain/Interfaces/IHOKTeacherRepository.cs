namespace MyEducation.WebAPI.Domain.Interfaces;


public interface IHOKTeacherRepository
{
    Teacher GetById(int id);

    Teacher Add(Teacher teacher);

    IEnumerable<Teacher> GetAll();

    Teacher Update(Teacher teacher);

    void Delete(int id);
}
