using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentalCompany.Migrations
{
    public partial class AddCustomerAndEquipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Customer_CustomerId",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_CustomerId",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Equipment");

            migrationBuilder.AddColumn<string>(
                name: "CustomerUserName",
                table: "Rental",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "Rental",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerUserName",
                table: "Rental");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "Rental");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Equipment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_CustomerId",
                table: "Equipment",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Customer_CustomerId",
                table: "Equipment",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");
        }
    }
}
