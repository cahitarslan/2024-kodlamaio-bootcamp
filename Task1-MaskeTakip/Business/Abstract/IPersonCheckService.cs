using Entities.Concrete;

namespace Business.Abstract;

public interface IPersonCheckService
{
    bool CheckPerson(Person person);
}
