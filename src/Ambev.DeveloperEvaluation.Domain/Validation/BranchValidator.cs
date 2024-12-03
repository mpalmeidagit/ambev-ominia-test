using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class BranchValidator : AbstractValidator<Branch>
  {
    public BranchValidator()
    {
      RuleFor(branch => branch.userManagerId)
        .NotEmpty()
        .WithMessage("userManagerId is required");
    }
  }
