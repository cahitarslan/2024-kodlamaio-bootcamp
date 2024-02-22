using Entities.Abstract;

namespace Entities.Dtos;

public class CategoryUpdateDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}
