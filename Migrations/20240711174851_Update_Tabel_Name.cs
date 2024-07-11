using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmTicketShop.Migrations
{
    /// <inheritdoc />
    public partial class Update_Tabel_Name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amout",
                table: "OrdersItems",
                newName: "Amount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "OrdersItems",
                newName: "Amout");
        }
    }
}
