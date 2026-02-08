namespace FinanceTracker.Models;

public class Debt
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public decimal PaidAmount { get; set; } // Bereits getilgt

    // Der Restbetrag (Berechnet)
    public decimal RemainingAmount => Amount - PaidAmount;

    // Wer fordert das Geld?
    public string CreditorUserId { get; set; } = string.Empty;

    // Wer schuldet das Geld? (Hier brauchen wir die E-Mail oder ID des anderen Users)
    public string DebtorEmail { get; set; } = string.Empty;
    public string DebtorName { get; set; } = string.Empty;

    public DebtStatus Status { get; set; } = DebtStatus.Pending;
    public List<Repayment> Repayments { get; set; } = new();
}

public enum DebtStatus
{
    Pending,    // Wartet auf Bestätigung
    Confirmed,  // Akzeptiert
    Rejected,   // Abgelehnt
    Paid        // Erledigt
}