using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RadiaTagineShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Tagine> Tagines { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrederDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Tagine de boeuf" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Tagine Poulet" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Tagine vegetarien" });

            //seed Tagines

            modelBuilder.Entity<Tagine>().HasData(new Tagine
            {
                TagineId = 1,
                Name = "Tagine boeuf ognion",
                Price = 12.95M,
                ShortDescription = "Our famous boeufTagines!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "https://www.la-cuisine-marocaine.com/photos-recettes/Tajine-de-viande-aux-oignons-et-raisins-secs.jpg",
                InStock = true,
                IsTagineOfTheWeek = true,
                ImageThumbnailUrl = "https://www.la-cuisine-marocaine.com/photos-recettes/Tajine-de-viande-aux-oignons-et-raisins-secs.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Tagine>().HasData(new Tagine
            {
                TagineId = 2,
                Name = "Tagine poulet olives",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImageUrl = "https://st4.depositphotos.com/4303215/25817/i/600/depositphotos_258175528-stock-photo-traditional-moroccan-tajine-of-chicken.jpg",
                InStock = true,
                IsTagineOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://st4.depositphotos.com/4303215/25817/i/600/depositphotos_258175528-stock-photo-traditional-moroccan-tajine-of-chicken.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Tagine>().HasData(new Tagine
            {
                TagineId = 3,
                Name = "Tagine legumes et olives",
                Price = 18.95M,
                ShortDescription = "Plain cheese cake. Plain pleasure.",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImageUrl = "https://recettes.de/images/blogs/cuisine-test-recette-et-test-de-cuisine/tajine-poulet-legumes-avec-carottes-et-pois-chiches-257.640x480.jpg",
                InStock = true,
                IsTagineOfTheWeek = false,
                ImageThumbnailUrl = "https://recettes.de/images/blogs/cuisine-test-recette-et-test-de-cuisine/tajine-poulet-legumes-avec-carottes-et-pois-chiches-257.640x480.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Tagine>().HasData(new Tagine
            {
                TagineId = 4,
                Name = "Tagine boeuf legumes",
                Price = 15.95M,
                ShortDescription = "A summer classic!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "http://www.lesfoodies.com/_recipeimage/71557/tajine-boeuf-legumes.jpg",
                InStock = true,
                IsTagineOfTheWeek = false,
                ImageThumbnailUrl = "http://www.lesfoodies.com/_recipeimage/71557/tajine-boeuf-legumes.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Tagine>().HasData(new Tagine
            {
                TagineId = 5,
                Name = "Christmas Apple Tagine",
                Price = 13.95M,
                ShortDescription = "Happy holidays with this Tagine!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasappleTagine.jpg",
                InStock = true,
                IsTagineOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasappleTaginesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Tagine>().HasData(new Tagine
            {
                TagineId = 6,
                Name = "Cranberry Tagine",
                Price = 17.95M,
                ShortDescription = "A Christmas favorite",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryTagine.jpg",
                InStock = true,
                IsTagineOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryTaginesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Tagine>().HasData(new Tagine
            {
                TagineId = 7,
                Name = "Peach Tagine",
                Price = 15.95M,
                ShortDescription = "Sweet as peach",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachTagine.jpg",
                InStock = false,
                IsTagineOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachTaginesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Tagine>().HasData(new Tagine
            {
                TagineId = 8,
                Name = "Pumpkin Tagine",
                Price = 12.95M,
                ShortDescription = "Our Halloween favorite",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinTagine.jpg",
                InStock = true,
                IsTagineOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinTaginesmall.jpg",
                AllergyInformation = ""
            });


            modelBuilder.Entity<Tagine>().HasData(new Tagine
            {
                TagineId = 9,
                Name = "Rhubarb Tagine",
                Price = 15.95M,
                ShortDescription = "My God, so sweet!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbTagine.jpg",
                InStock = true,
                IsTagineOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbTaginesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Tagine>().HasData(new Tagine
            {
                TagineId = 10,
                Name = "Strawberry Tagine",
                Price = 15.95M,
                ShortDescription = "Our delicious strawberry Tagine!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryTagine.jpg",
                InStock = true,
                IsTagineOfTheWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryTaginesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Tagine>().HasData(new Tagine
            {
                TagineId = 11,
                Name = "Strawberry Cheese Cake",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                LongDescription =
                    "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                InStock = false,
                IsTagineOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });
        }
    }
}
