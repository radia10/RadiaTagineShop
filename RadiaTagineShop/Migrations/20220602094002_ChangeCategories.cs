using Microsoft.EntityFrameworkCore.Migrations;

namespace RadiaTagineShop.Migrations
{
    public partial class ChangeCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 3,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 3, "Christmas Apple Tagine" });

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 6,
                column: "Name",
                value: "Cranberry Tagine");

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 7,
                column: "Name",
                value: "Peach Tagine");

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 8,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 3, "Pumpkin Tagine" });

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 9,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 10,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "Strawberry Tagine" });

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 11,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "Strawberry Cheese Cake" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 3,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 5,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "Tagine prune et boeuf" });

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 6,
                column: "Name",
                value: "Tagine carottes olives");

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 7,
                column: "Name",
                value: "Peach et boeuf Tagine");

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 8,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "Tagine poulet et pomme de terre " });

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 9,
                column: "CategoryId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 10,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "Tagine poulet prune" });

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 11,
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "tagine beauf au choix" });
        }
    }
}
