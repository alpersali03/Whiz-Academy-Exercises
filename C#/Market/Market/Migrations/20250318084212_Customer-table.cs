using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Market.Migrations
{
    /// <inheritdoc />
    public partial class Customertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AvailableStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FullName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "alice@example.com", "Alice Johnson", "123-456-7890" },
                    { 2, "bob@example.com", "Bob Smith", "987-654-3210" },
                    { 3, "charlie@example.com", "Charlie Davis", "555-666-7777" },
                    { 4, "diana@example.com", "Diana Roberts", "444-555-6666" },
                    { 5, "edward@example.com", "Edward Clark", "111-222-3333" },
                    { 6, "fiona@example.com", "Fiona Martinez", "888-999-0000" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableStock", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 10, "Laptop", 1200.99m },
                    { 2, 20, "Smartphone", 699.50m },
                    { 3, 50, "Headphones", 199.99m },
                    { 4, 15, "Tablet", 499.99m },
                    { 5, 30, "Smartwatch", 249.99m },
                    { 6, 25, "Monitor", 299.99m },
                    { 7, 40, "Keyboard", 89.99m },
                    { 8, 60, "Mouse", 49.99m },
                    { 9, 12, "Printer", 159.99m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "OrderDate", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 3, 18, 8, 42, 11, 592, DateTimeKind.Utc).AddTicks(6535), 1200.99m },
                    { 2, 2, new DateTime(2025, 3, 18, 8, 42, 11, 592, DateTimeKind.Utc).AddTicks(7021), 699.50m },
                    { 3, 3, new DateTime(2025, 3, 18, 8, 42, 11, 592, DateTimeKind.Utc).AddTicks(7022), 499.99m },
                    { 4, 4, new DateTime(2025, 3, 18, 8, 42, 11, 592, DateTimeKind.Utc).AddTicks(7023), 199.99m },
                    { 5, 5, new DateTime(2025, 3, 18, 8, 42, 11, 592, DateTimeKind.Utc).AddTicks(7024), 249.99m },
                    { 6, 6, new DateTime(2025, 3, 18, 8, 42, 11, 592, DateTimeKind.Utc).AddTicks(7171), 299.99m },
                    { 7, 1, new DateTime(2025, 3, 18, 8, 42, 11, 592, DateTimeKind.Utc).AddTicks(7172), 89.99m },
                    { 8, 2, new DateTime(2025, 3, 18, 8, 42, 11, 592, DateTimeKind.Utc).AddTicks(7173), 49.99m },
                    { 9, 3, new DateTime(2025, 3, 18, 8, 42, 11, 592, DateTimeKind.Utc).AddTicks(7174), 159.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
