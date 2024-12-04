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
  public Guid UserClientId { get; set; }
  public User? Client { get; set; } = null!;
  public Guid BranchId { get; set; }
  public Branch Branch { get; set; } = null!;
  public ICollection<SaleProduct> SalesProducts { get; } = new List<SaleProduct>();
  public float SaleValue { get; set; }
  public bool Cancelled { get; set; }
  public bool Finished { get; set; }
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
  /// <list type="bullet">branchId format</list>
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