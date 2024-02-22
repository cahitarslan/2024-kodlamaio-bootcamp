using Business.Utilities.Consts;
using Entities.Concrete;
using FluentValidation;

namespace Business.Validators;

public class InstructorValidator : AbstractValidator<Instructor>
{
    public InstructorValidator()
    {
        RuleFor(i => i.FirstName).NotEmpty().WithMessage(ValidationMessages.Instructor.FirstNameNotEmpty);
        RuleFor(i => i.FirstName).MinimumLength(3).WithMessage(ValidationMessages.Instructor.FirstNameMinimumLength);

        RuleFor(i => i.LastName).NotEmpty().WithMessage(ValidationMessages.Instructor.LastNameNotEmpty);
        RuleFor(i => i.LastName).MinimumLength(3).WithMessage(ValidationMessages.Instructor.LastNameMinimumLength);

        RuleFor(i => i.Email).NotEmpty().WithMessage(ValidationMessages.Instructor.EmailNotEmpty);
        RuleFor(i => i.Email).EmailAddress().WithMessage(ValidationMessages.Instructor.EmailEmailAddress);

        RuleFor(i => i.Bio).NotEmpty().WithMessage(ValidationMessages.Instructor.BioNotEmpty);
        RuleFor(i => i.Bio).MaximumLength(500).WithMessage(ValidationMessages.Instructor.BioMaximumLength);
    }
}
