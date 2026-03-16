namespace MyEducation.WebAPI.Domain.Interfaces;


public interface ITeacherRepository
{
    Teacher GetById(int id);

    Teacher Add(Teacher teacher);

    Teacher Update(Teacher teacher);

    void Delete(int id);
}
