using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;


/// <summary>
/// Represents a user in the system with authentication and profile information.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Stock : BaseEntity
{
  public Guid ProductId { get; set; }
  public ICollection<Product> Products { get; } = new List<Product>();
  public Guid BranchId { get; set; }
  public ICollection<Branch> Branch { get; } = new List<Branch>();
  public float Quantity { get; set; }
  /// <summary>
  /// Performs validation of the user entity using the UserValidator rules.
  /// </summary>
  /// <returns>
  /// A <see cref="ValidationResultDetail"/> containing:
  /// - IsValid: Indicates whether all validation rules passed
  /// - Errors: Collection of validation errors if any rules failed
  /// </returns>
  /// <remarks>
  /// <listheader>The validation includes checking:</listheader>
  /// <list type="bullet">productId format and length</list>
  /// <list type="bullet">branchId format</list>
  /// <list type="bullet">quantity number format</list>
  /// 
  /// </remarks>
  public ValidationResultDetail Validate()
  {
    var validator = new StockValidator();
    var result = validator.Validate(this);
    return new ValidationResultDetail
    {
      IsValid = result.IsValid,
      Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
    };
  }
}