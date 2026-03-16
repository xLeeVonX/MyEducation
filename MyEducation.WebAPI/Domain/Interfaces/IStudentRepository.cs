namespace MyEducation.WebAPI.Domain.Interfaces;


public interface IStudentRepository
{
    Student GetById(int id);

    Student Add(Student student);

    Student Update(Student student);

    void Delete(int id);
}
