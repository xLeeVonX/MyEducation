namespace MyEducation.WebAPI.Domain.Interfaces;


public interface IHOKSubjectRepository
{
    Subject GetById(int id);

    Subject Add(Subject subject);

    IEnumerable<Subject> GetAll();

    Subject Update(Subject subject);

    void Delete(int id);
}
