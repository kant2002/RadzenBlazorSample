using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RadzenBlazorSample.Data;

/// <summary>
/// Information about user registration
/// </summary>
public class ApplicationUser : IdentityUser
{
    /// <summary>
    /// Gets or sets first name of the user.
    /// </summary>
    [MaxLength(100)]
    public required string FirstName { get; set; }

    /// <summary>
    /// Gets or sets last name of the user.
    /// </summary>
    [MaxLength(100)]
    public required string LastName { get; set; }
}

