using Microsoft.EntityFrameworkCore.Migrations;

namespace OSMS.Migrations
{
    public partial class sellOrder_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "SellOrde",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "SellOrde");
        }
    }
}
