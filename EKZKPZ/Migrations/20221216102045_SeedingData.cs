using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EKZKPZ.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clothing",
                columns: new[] { "Id", "Brand", "Model", "Name", "Price", "ProductionDate", "Quantity", "Size" },
                values: new object[] { 1, "Nike", "12afe321", "Sweetshot", 100f, new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2 });

            migrationBuilder.InsertData(
                table: "Clothing",
                columns: new[] { "Id", "Brand", "Model", "Name", "Price", "ProductionDate", "Quantity", "Size" },
                values: new object[] { 2, "Adiddas", "12asdfdf1", "Shoes", 500f, new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 0 });

            migrationBuilder.InsertData(
                table: "Clothing",
                columns: new[] { "Id", "Brand", "Model", "Name", "Price", "ProductionDate", "Quantity", "Size" },
                values: new object[] { 3, "Puma", "12adfer321", "Cap", 50f, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clothing",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clothing",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clothing",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
