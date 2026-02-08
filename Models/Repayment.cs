public class Repayment
{
    public int Id { get; set; }
    public int DebtId { get; set; } // Verknüpfung zur Schuld
    public decimal Amount { get; set; }
    public DateTime DatePaid { get; set; } = DateTime.Now;
}