using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class ProductValidator : AbstractValidator<Product>
{
  public ProductValidator()
  {
    RuleFor(product => product.name)
      .NotEmpty()
      .WithMessage("name is required");
    RuleFor(product => product.price)
      .NotEmpty()
      .WithMessage("price is required");
  }
}
