using Microsoft.EntityFrameworkCore.Migrations;

namespace EKZKPZ.Migrations
{
    public partial class DiscountChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "Clothing",
                type: "int",
                nullable: false,
                computedColumnSql: "DATEDIFF(MONTH, [ProductionDate], GETDATE()) * 5",
                oldClrType: typeof(int),
                oldType: "int",
                oldComputedColumnSql: "DATEDIFF(MONTH, [ProductionDate], GETDATE()) * 10");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "Clothing",
                type: "int",
                nullable: false,
                computedColumnSql: "DATEDIFF(MONTH, [ProductionDate], GETDATE()) * 10",
                oldClrType: typeof(int),
                oldType: "int",
                oldComputedColumnSql: "DATEDIFF(MONTH, [ProductionDate], GETDATE()) * 5");
        }
    }
}
