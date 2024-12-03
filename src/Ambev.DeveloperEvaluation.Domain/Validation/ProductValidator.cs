using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class ProductValidator : AbstractValidator<Product>
{
  public ProductValidator()
  {
    RuleFor(product => product.Name)
      .NotEmpty()
      .WithMessage("name is required");
    RuleFor(product => product.Price)
      .NotEmpty()
      .WithMessage("price is required");
  }
}
