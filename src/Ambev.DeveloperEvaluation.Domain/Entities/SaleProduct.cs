using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;


/// <summary>
/// Represents a user in the system with authentication and profile information.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class SaleProduct : BaseEntity
{
  public Guid SaleId { get; set; }
  public Sale? Sale { get; set; } = null!;
  public string ProductName { get; set; } = string.Empty;
  public float? Discount { get; set; }
  public float ValueTotal { get; set; }
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
  /// <list type="bullet">saleId format and length</list>
  /// <list type="bullet">productName format</list>
  /// <list type="bullet">discount number format</list>
  /// <list type="bullet">valueTotal complexity requirements</list>
  /// 
  /// </remarks>
  public ValidationResultDetail Validate()
  {
    var validator = new SaleProductValidator();
    var result = validator.Validate(this);
    return new ValidationResultDetail
    {
      IsValid = result.IsValid,
      Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
    };
  }
}