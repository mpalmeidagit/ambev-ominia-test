using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class StockValidator : AbstractValidator<Stock>
{
  public StockValidator()
  {
    RuleFor(saleProduct => saleProduct.Quantity)
      .NotEmpty()
      .WithMessage("quantity is required");
    RuleFor(saleProduct => saleProduct.BranchId)
      .NotEmpty()
      .WithMessage("branchId is required");
    RuleFor(saleProduct => saleProduct.Quantity)
      .NotEmpty()
      .WithMessage("quantity is required");
  }
}
