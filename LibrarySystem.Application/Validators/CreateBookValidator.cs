using FluentValidation;
using LibrarySystem.Application.DTOs;

namespace LibrarySystem.Application.Validators;

public class CreateBookValidator : AbstractValidator<CreateBookDto>
{
    public CreateBookValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title is required");

        RuleFor(x => x.Author)
            .NotEmpty().WithMessage("Author is required");
    }
}