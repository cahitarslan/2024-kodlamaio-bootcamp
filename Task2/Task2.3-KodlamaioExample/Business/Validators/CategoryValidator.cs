using Business.Utilities.Consts;
using Entities.Concrete;
using FluentValidation;

namespace Business.Validators;

public class CategoryValidator : AbstractValidator<Category>
{
    public CategoryValidator()
    {
        RuleFor(c => c.Name).NotEmpty().WithMessage(ValidationMessages.Category.NameNotEmpty);
        RuleFor(c => c.Name).MinimumLength(3).WithMessage(ValidationMessages.Category.NameMinimumLength);
        RuleFor(c => c.Name).MaximumLength(50).WithMessage(ValidationMessages.Category.NameMaximumLength);
    }
}
