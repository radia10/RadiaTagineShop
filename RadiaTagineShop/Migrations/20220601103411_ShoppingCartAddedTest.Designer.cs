﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RadiaTagineShop.Models;

namespace RadiaTagineShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220601103411_ShoppingCartAddedTest")]
    partial class ShoppingCartAddedTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RadiaTagineShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Tagine de boeuf"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Tagine Poulet"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Tagine vegetarien"
                        });
                });

            modelBuilder.Entity("RadiaTagineShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TagineId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("TagineId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("RadiaTagineShop.Models.Tagine", b =>
                {
                    b.Property<int>("TagineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllergyInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTagineOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagineId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Tagines");

                    b.HasData(
                        new
                        {
                            TagineId = 1,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://www.la-cuisine-marocaine.com/photos-recettes/Tajine-de-viande-aux-oignons-et-raisins-secs.jpg",
                            ImageUrl = "https://www.la-cuisine-marocaine.com/photos-recettes/Tajine-de-viande-aux-oignons-et-raisins-secs.jpg",
                            InStock = true,
                            IsTagineOfTheWeek = true,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Tagine boeuf ognion",
                            Price = 12.95m,
                            ShortDescription = "Our famous boeufTagines!"
                        },
                        new
                        {
                            TagineId = 2,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://st4.depositphotos.com/4303215/25817/i/600/depositphotos_258175528-stock-photo-traditional-moroccan-tajine-of-chicken.jpg",
                            ImageUrl = "https://st4.depositphotos.com/4303215/25817/i/600/depositphotos_258175528-stock-photo-traditional-moroccan-tajine-of-chicken.jpg",
                            InStock = true,
                            IsTagineOfTheWeek = false,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Tagine poulet olives",
                            Price = 18.95m,
                            ShortDescription = "You'll love it!"
                        },
                        new
                        {
                            TagineId = 3,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://recettes.de/images/blogs/cuisine-test-recette-et-test-de-cuisine/tajine-poulet-legumes-avec-carottes-et-pois-chiches-257.640x480.jpg",
                            ImageUrl = "https://recettes.de/images/blogs/cuisine-test-recette-et-test-de-cuisine/tajine-poulet-legumes-avec-carottes-et-pois-chiches-257.640x480.jpg",
                            InStock = true,
                            IsTagineOfTheWeek = false,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Tagine legumes et olives",
                            Price = 18.95m,
                            ShortDescription = "Plain cheese cake. Plain pleasure."
                        },
                        new
                        {
                            TagineId = 4,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "http://www.lesfoodies.com/_recipeimage/71557/tajine-boeuf-legumes.jpg",
                            ImageUrl = "http://www.lesfoodies.com/_recipeimage/71557/tajine-boeuf-legumes.jpg",
                            InStock = true,
                            IsTagineOfTheWeek = false,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Tagine boeuf legumes",
                            Price = 15.95m,
                            ShortDescription = "A summer classic!"
                        },
                        new
                        {
                            TagineId = 5,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasappleTaginesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasappleTagine.jpg",
                            InStock = true,
                            IsTagineOfTheWeek = false,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Christmas Apple Tagine",
                            Price = 13.95m,
                            ShortDescription = "Happy holidays with this Tagine!"
                        },
                        new
                        {
                            TagineId = 6,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryTaginesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberryTagine.jpg",
                            InStock = true,
                            IsTagineOfTheWeek = false,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Cranberry Tagine",
                            Price = 17.95m,
                            ShortDescription = "A Christmas favorite"
                        },
                        new
                        {
                            TagineId = 7,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachTaginesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachTagine.jpg",
                            InStock = false,
                            IsTagineOfTheWeek = false,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Peach Tagine",
                            Price = 15.95m,
                            ShortDescription = "Sweet as peach"
                        },
                        new
                        {
                            TagineId = 8,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinTaginesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinTagine.jpg",
                            InStock = true,
                            IsTagineOfTheWeek = true,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Pumpkin Tagine",
                            Price = 12.95m,
                            ShortDescription = "Our Halloween favorite"
                        },
                        new
                        {
                            TagineId = 9,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbTaginesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbTagine.jpg",
                            InStock = true,
                            IsTagineOfTheWeek = true,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Rhubarb Tagine",
                            Price = 15.95m,
                            ShortDescription = "My God, so sweet!"
                        },
                        new
                        {
                            TagineId = 10,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryTaginesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryTagine.jpg",
                            InStock = true,
                            IsTagineOfTheWeek = false,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Strawberry Tagine",
                            Price = 15.95m,
                            ShortDescription = "Our delicious strawberry Tagine!"
                        },
                        new
                        {
                            TagineId = 11,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                            InStock = false,
                            IsTagineOfTheWeek = false,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Strawberry Cheese Cake",
                            Price = 18.95m,
                            ShortDescription = "You'll love it!"
                        });
                });

            modelBuilder.Entity("RadiaTagineShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("RadiaTagineShop.Models.Tagine", "Tagine")
                        .WithMany()
                        .HasForeignKey("TagineId");
                });

            modelBuilder.Entity("RadiaTagineShop.Models.Tagine", b =>
                {
                    b.HasOne("RadiaTagineShop.Models.Category", "Category")
                        .WithMany("Tagines")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
