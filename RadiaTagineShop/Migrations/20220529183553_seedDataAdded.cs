using Microsoft.EntityFrameworkCore.Migrations;

namespace RadiaTagineShop.Migrations
{
    public partial class seedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Tagines",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Fruit Tagines", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Cheese cakes", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Seasonal Tagines", null });

            migrationBuilder.InsertData(
                table: "Tagines",
                columns: new[] { "TagineId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsTagineOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/appleTaginesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/appleTagine.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", "Apple Tagine", 12.95m, "Our famous apple Tagines!" },
                    { 4, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/cherryTaginesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherryTagine.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", "Cherry Tagine", 15.95m, "A summer classic!" },
                    { 7, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/peachTaginesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachTagine.jpg", false, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", "Peach Tagine", 15.95m, "Sweet as peach" },
                    { 9, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbTaginesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbTagine.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", "Rhubarb Tagine", 15.95m, "My God, so sweet!" },
                    { 10, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryTaginesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryTagine.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", "Strawberry Tagine", 15.95m, "Our delicious strawberry Tagine!" },
                    { 2, "", 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", "Blueberry Cheese Cake", 18.95m, "You'll love it!" },
                    { 3, "", 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", "Cheese Cake", 18.95m, "Plain cheese cake. Plain pleasure." },
                    { 11, "", 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", false, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", "Strawberry Cheese Cake", 18.95m, "You'll love it!" },
                    { 5, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasappleTaginesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasappleTagine.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", "Christmas Apple Tagine", 13.95m, "Happy holidays with this Tagine!" },
                    { 6, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryTaginesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryTagine.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", "Cranberry Tagine", 17.95m, "A Christmas favorite" },
                    { 8, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinTaginesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinTagine.jpg", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", "Pumpkin Tagine", 12.95m, "Our Halloween favorite" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tagines",
                keyColumn: "TagineId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Tagines",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");
        }
    }
}
