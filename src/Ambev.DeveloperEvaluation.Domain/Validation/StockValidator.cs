using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class StockValidator : AbstractValidator<Stock>
{
  public StockValidator()
  {
    RuleFor(product => product.quantity)
      .NotEmpty()
      .WithMessage("quantity is required");
    RuleFor(product => product.brancheId)
      .NotEmpty()
      .WithMessage("brancheId is required");
    RuleFor(product => product.quantity)
      .NotEmpty()
      .WithMessage("quantity is required");
  }
}
