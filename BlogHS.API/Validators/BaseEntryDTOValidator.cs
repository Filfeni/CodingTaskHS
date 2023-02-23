using BlogHS.Domain.Models.Entry;
using FluentValidation;

namespace BlogHS.API.Validators
{
    public class BaseEntryDTOValidator : AbstractValidator<BaseEntryDTO>
    {
        public BaseEntryDTOValidator()
        {
            RuleFor(model => model.Title).NotNull().NotEmpty().WithMessage("Please specify a Title");
            RuleFor(model => model.Content).NotNull().NotEmpty().WithMessage("Please specify a Content");
            RuleFor(model => model.ThumbnailUrl).NotNull().NotEmpty().WithMessage("Please specify a Thumbnail");
            RuleFor(model => model.ThumbnailContent).NotNull().NotEmpty().WithMessage("Please specify a Thumbnail");
            RuleFor(model => model.CreationDate).NotNull().NotEmpty().Must(x => BeAValidDate(x.Value)).WithMessage("The field CreationDate is not valid");
        }
        private bool BeAValidDate(DateTimeOffset date)
        {
            return !date.Equals(default(DateTimeOffset));
        }
    }
}
