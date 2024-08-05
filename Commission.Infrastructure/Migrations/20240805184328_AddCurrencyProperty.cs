using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Commission.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCurrencyProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrencyCode",
                table: "SaleCommissions",
                type: "nvarchar(3)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrencyCode",
                table: "SaleCommissions");
        }
    }
}
