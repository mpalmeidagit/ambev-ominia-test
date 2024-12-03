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
  public Guid productId { get; set; }
  public ICollection<Product>? products { get; set; }
  public Guid brancheId { get; set; }
  public Branch? branch { get; set; }
  public float quantity { get; set; }
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
  /// <list type="bullet">brancheId format</list>
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