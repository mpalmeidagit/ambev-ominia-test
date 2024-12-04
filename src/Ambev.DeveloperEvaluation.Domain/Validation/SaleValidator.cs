using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class SaleValidator : AbstractValidator<Sale>
{
  public SaleValidator()
  {
    RuleFor(sale => sale.UserClientId)
      .NotEmpty()
      .WithMessage("userClientId is required");
    
    // RuleFor(sale => sale.BranchId)
    //   .NotEmpty()
    //   .WithMessage("branchId is required");
      
    RuleFor(sale => sale.SaleValue)
      .NotEmpty()
      .WithMessage("saleValue is required");
  }
}
