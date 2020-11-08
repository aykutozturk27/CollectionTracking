using CollectionTracking.Entities.Concrete;
using FluentValidation;

namespace CollectionTracking.Business.ValidationRules.FluentValidation
{
    public class FilmValidator : AbstractValidator<Film>
    {
        public FilmValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Film ismi boş olamaz");
            RuleFor(x => x.Type).NotEmpty().WithMessage("Film tipi boş olamaz");
        }
    }
}
