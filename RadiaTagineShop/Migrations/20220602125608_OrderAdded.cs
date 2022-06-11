using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RadiaTagineShop.Migrations
{
    public partial class OrderAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oreders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oreders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "OrederDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    TagineId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrederDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrederDetails_Oreders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Oreders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrederDetails_Tagines_TagineId",
                        column: x => x.TagineId,
                        principalTable: "Tagines",
                        principalColumn: "TagineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrederDetails_OrderId",
                table: "OrederDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrederDetails_TagineId",
                table: "OrederDetails",
                column: "TagineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrederDetails");

            migrationBuilder.DropTable(
                name: "Oreders");
        }
    }
}
