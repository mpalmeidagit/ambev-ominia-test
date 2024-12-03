using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class SaleProductValidator : AbstractValidator<SaleProduct>
{
  public SaleProductValidator()
  {
    RuleFor(product => product.saleId)
      .NotEmpty()
      .WithMessage("saleId is required");
    RuleFor(product => product.productName)
      .NotEmpty()
      .WithMessage("productName is required");
    RuleFor(product => product.valueTotal)
      .NotEmpty()
      .WithMessage("valueTotal is required");
  }
}
