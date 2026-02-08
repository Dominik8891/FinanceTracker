using Microsoft.AspNetCore.Identity;

namespace FinanceTracker.Models;

public class ApplicationUser : IdentityUser
{
    // Hier können wir später eigene Felder hinzufügen, 
    // z.B. ein Profilbild oder eine bevorzugte Währung.
    public string FullName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
}