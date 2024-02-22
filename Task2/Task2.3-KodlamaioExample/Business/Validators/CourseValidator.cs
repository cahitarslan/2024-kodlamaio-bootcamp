using Business.Utilities.Consts;
using Entities.Concrete;
using FluentValidation;

namespace Business.Validators;

public class CourseValidator : AbstractValidator<Course>
{
    public CourseValidator()
    {
        RuleFor(c => c.Title).NotEmpty().WithMessage(ValidationMessages.Course.TitleNotEmpty);
        RuleFor(c => c.Title).MinimumLength(5).WithMessage(ValidationMessages.Course.TitleMinimumLength);
        RuleFor(c => c.Title).MaximumLength(50).WithMessage(ValidationMessages.Course.TitleMaximumLength);

        RuleFor(c => c.Description).NotEmpty().WithMessage(ValidationMessages.Course.DescriptionNotEmpty);
        RuleFor(c => c.Description).MinimumLength(10).WithMessage(ValidationMessages.Course.DescriptionMinimumLength);
        RuleFor(c => c.Description).MaximumLength(500).WithMessage(ValidationMessages.Course.DescriptionMaximumLength);

        RuleFor(c => c.InstructorId).NotEmpty().WithMessage(ValidationMessages.Course.InstructorNotEmpty);

        RuleFor(c => c.CategoryId).NotEmpty().WithMessage(ValidationMessages.Course.CategoryNotEmpty);
    }
}
