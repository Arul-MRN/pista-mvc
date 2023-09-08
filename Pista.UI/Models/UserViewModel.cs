
using System.ComponentModel.DataAnnotations;

namespace Pista.UI.Models;

public class UserViewModel
{
    [Required]
    public string UserId { get; set; } = null!;

    public string? Designation { get; set; }
    [Required]
    public string Name { get; set; } = null!;
    [Required]
    public string Category { get; set; } = null!;
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;
    [Required]
    public string Mobile { get; set; } = null!;
    [Required]
    public string Password { get; set; } = null!;
    [Required]
    public string ConfirmPassword { get; set; } = null!;
}
