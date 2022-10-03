using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        // Fluent Validation - Fluent Doğrulama
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Ürün İsmi Girilmeli!");
            RuleFor(p => p.Category).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Fiyat Bilgisi Girilmeli!");
            RuleFor(p => p.StockAmount).NotEmpty().WithMessage("Stok Bilgisi Girilmeli!");
            RuleFor(p => p.Company).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.StockAmount).GreaterThanOrEqualTo(0);
        }
    }
}
