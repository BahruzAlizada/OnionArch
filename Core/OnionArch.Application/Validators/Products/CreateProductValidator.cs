

using FluentValidation;
using OnionArch.Application.ViewModels;

namespace OnionArch.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<CreateProductVM>
    {
        public CreateProductValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().NotNull().WithMessage("Bu xana boş ola bilməz")
                .MinimumLength(2).MaximumLength(100).WithMessage("Məhsul adı minimum 2, maksimum 100 hərf olmalıdır.");

            RuleFor(x => x.Stock).NotNull().NotEmpty().WithMessage("Bu xana boş ola bilməz").
                Must(x => x >= 0).WithMessage("Stok sayı mənfi ola bilməz");

            RuleFor(x => x.Price).NotNull().NotEmpty().WithMessage("Bu xana boş ola bilməz").
                Must(x => x >= 0).WithMessage("Qiymət sayı mənfi ola bilməz");
        }
    }
}
