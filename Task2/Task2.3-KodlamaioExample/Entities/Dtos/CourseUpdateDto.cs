using Entities.Abstract;

namespace Entities.Dtos;

public class CourseUpdateDto : IDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public int CategoryId { get; set; }
    public int InstructorId { get; set; }
}
