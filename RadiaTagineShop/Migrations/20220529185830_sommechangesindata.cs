using Microsoft.EntityFrameworkCore.Migrations;

namespace RadiaTagineShop.Migrations
{
    public partial class sommechangesindata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Tagine de boeuf");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "Tagine Poulet");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryName",
                value: "Tagine vegetarien");

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://www.la-cuisine-marocaine.com/photos-recettes/Tajine-de-viande-aux-oignons-et-raisins-secs.jpg", "https://www.la-cuisine-marocaine.com/photos-recettes/Tajine-de-viande-aux-oignons-et-raisins-secs.jpg", "Tagine boeuf ognion", "Our famous boeufTagines!" });

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "https://st4.depositphotos.com/4303215/25817/i/600/depositphotos_258175528-stock-photo-traditional-moroccan-tajine-of-chicken.jpg", "https://st4.depositphotos.com/4303215/25817/i/600/depositphotos_258175528-stock-photo-traditional-moroccan-tajine-of-chicken.jpg", "Tagine poulet olives" });

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "https://recettes.de/images/blogs/cuisine-test-recette-et-test-de-cuisine/tajine-poulet-legumes-avec-carottes-et-pois-chiches-257.640x480.jpg", "https://recettes.de/images/blogs/cuisine-test-recette-et-test-de-cuisine/tajine-poulet-legumes-avec-carottes-et-pois-chiches-257.640x480.jpg", "Tagine legumes et olives" });

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "http://www.lesfoodies.com/_recipeimage/71557/tajine-boeuf-legumes.jpg", "http://www.lesfoodies.com/_recipeimage/71557/tajine-boeuf-legumes.jpg", "Tagine boeuf legumes" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryName",
                value: "Fruit Tagines");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "Cheese cakes");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryName",
                value: "Seasonal Tagines");

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name", "ShortDescription" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/appleTaginesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/appleTagine.jpg", "Apple Tagine", "Our famous apple Tagines!" });

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", "Blueberry Cheese Cake" });

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", "Cheese Cake" });

            migrationBuilder.UpdateData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "Name" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/cherryTaginesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherryTagine.jpg", "Cherry Tagine" });
        }
    }
}
