using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PersonCheckManager : IPersonCheckService
{
    // For test
    public bool CheckPerson(Person person)
    {
        return true;
    }
}
