﻿using Entities.Abstract;

namespace Entities.Dtos;

public class InstructorGetDto : IDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Bio { get; set; }

    //public ICollection<Course>? Courses { get; set; }
}
