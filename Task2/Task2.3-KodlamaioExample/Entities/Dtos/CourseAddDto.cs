using Entities.Abstract;

namespace Entities.Dtos;

public class CourseAddDto: IDto
{
    public string Title { get; set; }
    public string Description { get; set; }

    public int InstructorId { get; set; }
    public int CategoryId { get; set; }
}
