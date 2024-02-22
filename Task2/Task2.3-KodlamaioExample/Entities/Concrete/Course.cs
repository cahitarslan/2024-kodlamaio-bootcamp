using Entities.Abstract;

namespace Entities.Concrete;

public class Course : IEntity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public int InstructorId { get; set; }
    public Instructor Instructor { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } 
}
