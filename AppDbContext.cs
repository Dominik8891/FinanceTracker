using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FinanceTracker.Models; // WICHTIG: Pfad zu deinen Models

namespace FinanceTracker.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // Hier werden die Tabellen für die Datenbank registriert:
    public DbSet<Debt> Debts { get; set; }
    public DbSet<Repayment> Repayments { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Optional: Hier kannst du festlegen, dass beim Löschen einer Schuld 
        // auch alle zugehörigen Zahlungen gelöscht werden (Cascade Delete)
        builder.Entity<Repayment>()
            .HasOne<Debt>()
            .WithMany(d => d.Repayments)
            .HasForeignKey(r => r.DebtId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}