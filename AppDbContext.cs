using Microsoft.EntityFrameworkCore;
using FinanceTracker.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Das wird unsere Tabelle in der Datenbank
    public DbSet<Transaction> Transactions { get; set; }
}