using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSMS.Migrations
{
    public partial class sellOrder_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SellOrde");

            migrationBuilder.CreateTable(
                name: "SellOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    OrgName = table.Column<string>(nullable: true),
                    Station = table.Column<string>(nullable: true),
                    Product = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: true),
                    Count = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Remaining = table.Column<decimal>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    DriverName = table.Column<string>(nullable: true),
                    CardNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellOrder", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SellOrder");

            migrationBuilder.CreateTable(
                name: "SellOrde",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<decimal>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false),
                    CardNo = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Count = table.Column<decimal>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    DriverName = table.Column<string>(nullable: true),
                    OrgName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Product = table.Column<string>(nullable: true),
                    Remaining = table.Column<decimal>(nullable: false),
                    Station = table.Column<string>(nullable: true),
                    TimeCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellOrde", x => x.Id);
                });
        }
    }
}
