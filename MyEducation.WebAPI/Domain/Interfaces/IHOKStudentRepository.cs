namespace MyEducation.WebAPI.Domain.Interfaces;


public interface IHOKStudentRepository
{
    Student GetById(int id);

    Student Add(Student student);

    IEnumerable<Student> GetAll();

    Student Update(Student student);

    void Delete(int id);
}
