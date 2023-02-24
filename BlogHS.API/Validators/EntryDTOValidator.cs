using BlogHS.Domain.Models.Entry;
using FluentValidation;

namespace BlogHS.API.Validators
{
    public class EntryDTOValidator : AbstractValidator<EntryDTO>
    {
        public EntryDTOValidator()
        {
            RuleFor(model => model.Id).NotEqual(0)
                                      .WithMessage("Please specify Id");
            RuleFor(model => model.Title).NotNull()
                                         .NotEmpty()
                                         .WithMessage("Please specify a Title");
            RuleFor(model => model.Content).NotNull()
                                           .NotEmpty()
                                           .WithMessage("Please specify a Content")
                                           .MinimumLength(10)
                                           .WithMessage("The Content should have at least 10 characters");
            RuleFor(model => model.ThumbnailUrl).NotNull()
                                                .NotEmpty()
                                                .WithMessage("The Thumbnail cannot be empty");
            RuleFor(model => model.ThumbnailContent).NotNull()
                                                    .NotEmpty()
                                                    .WithMessage("Please specify a Valid Image");
            RuleFor(model => model.CreationDate).NotNull()
                                                .NotEmpty()
                                                .Must(x => BeAValidDate(x.Value))
                                                .WithMessage("The field CreationDate is not valid");
        }
        private bool BeAValidDate(DateTimeOffset date)
        {
            return !date.Equals(default(DateTimeOffset));
        }
    }
}
