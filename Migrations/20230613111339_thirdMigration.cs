using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webshop.Migrations
{
    /// <inheritdoc />
    public partial class thirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingRequests_Customers_CustomerId",
                table: "BookingRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43700c97-c906-426b-98ec-172447b0da7e", "AQAAAAEAACcQAAAAEErrV10cFCLyJyzerAlCB13p1ul6f6ozvHBx+A55BkuerXtF9UN+NyiyD7H1vZI4Hw==", "9a8d7f80-2bcc-49af-a822-3a11f33f51ed" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookingRequests_Customer_CustomerId",
                table: "BookingRequests",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingRequests_Customer_CustomerId",
                table: "BookingRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bbee2b5-8d82-42f9-9566-9eba6a8f899c", "AQAAAAEAACcQAAAAELWtYtKtNgmIxcWyM1DdDFkQGijomlEoxJJgxAu/NUyzJuNGmViEWIxTuzKOqLmyUg==", "537c4483-82d7-400b-a2fd-5116f3b30555" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookingRequests_Customers_CustomerId",
                table: "BookingRequests",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
