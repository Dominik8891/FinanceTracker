using Microsoft.AspNetCore.Identity;

namespace FinanceTracker.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public bool IsPasswordResetPending { get; set; } = false;
    public string? PasswordResetCode { get; set; }
}