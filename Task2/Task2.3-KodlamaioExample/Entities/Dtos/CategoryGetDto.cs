using Entities.Abstract;

namespace Entities.Dtos;

public class CategoryGetDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }

    //public virtual ICollection<Course>? Courses { get; set; }
}
