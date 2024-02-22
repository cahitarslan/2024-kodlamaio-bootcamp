using Entities.Abstract;

namespace Entities.Dtos;

public class InstructorAddDto: IDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Bio { get; set; }
}
