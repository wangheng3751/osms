using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OSMS.Migrations
{
    public partial class sellorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SellOrde",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TimeCreated = table.Column<DateTime>(nullable: false),
                    OrgName = table.Column<string>(nullable: true),
                    Station = table.Column<string>(nullable: true),
                    Product = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_SellOrde", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SellOrde");
        }
    }
}
