using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PttManager : ISupplierService
{
    private readonly IPersonCheckService _personCheckService;

    public PttManager(IPersonCheckService personCheckService)
    {
        _personCheckService = personCheckService;
    }

    public void GiveMask(Person person)
    {
        if (_personCheckService.CheckPerson(person))
        {
            Console.WriteLine(person.FirstName + " için maske verildi");
        }
        else
        {
            Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
        }
    }
}
