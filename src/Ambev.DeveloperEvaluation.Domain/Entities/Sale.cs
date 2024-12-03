using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Entities;


/// <summary>
/// Represents a user in the system with authentication and profile information.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Sale : BaseEntity
{
  public Guid userClientId { get; set; }
  public User? client { get; set; } = null!;
  public Guid brancheId { get; set; }
  public Branch? branch { get; set; } = null!;
  public ICollection<SaleProduct>? salesProduct { get; set; } = new List<SaleProduct>();
  public float saleValue { get; set; }
  public bool cancelled { get; set; }
  public bool finished { get; set; }
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
  /// <list type="bullet">userClientId format and length</list>
  /// <list type="bullet">brancheId format</list>
  /// <list type="bullet">saleValue number format</list>
  /// <list type="bullet">cancelled complexity requirements</list>
  /// <list type="bullet">finished validity</list>
  /// 
  /// </remarks>
  public ValidationResultDetail Validate()
  {
    var validator = new SaleValidator();
    var result = validator.Validate(this);
    return new ValidationResultDetail
    {
      IsValid = result.IsValid,
      Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
    };
  }
}