namespace RadzenBlazorSample.Data;

public class UserOrganizationUnit
{
    /// <summary>
    /// Gets or sets id of the user organization unit entry.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets user which records presence in the organization unit.
    /// </summary>
    public required ApplicationUser User { get; set; }

    /// <summary>
    /// Gets or sets organization unit where user is present.
    /// </summary>
    public required OrganizationUnit OrganizationUnit { get; set; }

    /// <summary>
    /// Gets or sets date when user starts working in the organization unit.
    /// </summary>
    public required DateTime StartDate { get; set; }
}
