using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceTracker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDebtWorkflow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InitialAmount",
                table: "Debts",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "DueDate",
                table: "Debts",
                newName: "DebtorEmail");

            migrationBuilder.RenameColumn(
                name: "CurrentAmount",
                table: "Debts",
                newName: "CreditorUserId");

            migrationBuilder.RenameColumn(
                name: "Creditor",
                table: "Debts",
                newName: "Amount");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Debts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Debts");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Debts",
                newName: "InitialAmount");

            migrationBuilder.RenameColumn(
                name: "DebtorEmail",
                table: "Debts",
                newName: "DueDate");

            migrationBuilder.RenameColumn(
                name: "CreditorUserId",
                table: "Debts",
                newName: "CurrentAmount");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Debts",
                newName: "Creditor");
        }
    }
}
