using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentalId).NotEmpty();
            RuleFor(r => r.CustomerId).NotEmpty();
            RuleFor(r => r.CustomerId).NotEmpty();

        }
    }
}
