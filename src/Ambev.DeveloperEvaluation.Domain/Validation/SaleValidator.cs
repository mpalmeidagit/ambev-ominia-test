using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class SaleValidator : AbstractValidator<Sale>
{
  public SaleValidator()
  {
    RuleFor(sale => sale.userClientId)
      .NotEmpty()
      .WithMessage("userClientId is required");
    
    RuleFor(sale => sale.brancheId)
      .NotEmpty()
      .WithMessage("brancheId is required");
      
    RuleFor(sale => sale.saleValue)
      .NotEmpty()
      .WithMessage("saleValue is required");
  }
}
