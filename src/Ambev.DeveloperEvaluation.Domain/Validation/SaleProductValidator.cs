using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class SaleProductValidator : AbstractValidator<SaleProduct>
{
  public SaleProductValidator()
  {
    RuleFor(saleProduct => saleProduct.SaleId)
      .NotEmpty()
      .WithMessage("saleId is required");
    RuleFor(saleProduct => saleProduct.ProductName)
      .NotEmpty()
      .WithMessage("productName is required");
    RuleFor(saleProduct => saleProduct.ValueTotal)
      .NotEmpty()
      .WithMessage("valueTotal is required");
  }
}
