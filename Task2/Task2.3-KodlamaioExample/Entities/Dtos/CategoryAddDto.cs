using Entities.Abstract;

namespace Entities.Dtos;

public class CategoryAddDto : IDto
{
    public string Name { get; set; }
    public string? Description { get; set; }
}
