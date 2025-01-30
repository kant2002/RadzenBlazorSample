using System.ComponentModel.DataAnnotations;

namespace RadzenBlazorSample.Data;

/// <summary>
/// Information about contract.
/// </summary>
public class Contract
{
    /// <summary>
    /// Gets or sets unique identifier for the contract.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets identification contract number for the contract.
    /// </summary>
    [MaxLength(20)]
    public required string ContractNumber { get; set; }

    /// <summary>
    /// Gets or sets manager responsibe for the contract.
    /// </summary>
    public required ApplicationUser Manager { get; set; }
}
