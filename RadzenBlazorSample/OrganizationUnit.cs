using System.ComponentModel.DataAnnotations;

namespace RadzenBlazorSample;

/// <summary>
/// Information about organization unit.
/// </summary>
public class OrganizationUnit
{
    /// <summary>
    /// Gets or sets id of the organization unit.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets name of the organization unit.
    /// </summary>
    [MaxLength(100)]
    public required string Name { get; set; }

    /// <summary>
    /// Gets or sets responsibilities for the organization unit.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets parent organization unit.
    /// </summary>
    public OrganizationUnit? Parent { get; set; }
}
