﻿using System.Collections.Generic;
using System.Linq;

namespace RadiaTagineShop.Models
{
    public class MockTagineRepository : ITagineRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Tagine> AllTagines => new List<Tagine>
            {
                new Tagine {TagineId = 1, Name="Tagine boeuf ognion", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://www.la-cuisine-marocaine.com/photos-recettes/Tajine-de-viande-aux-oignons-et-raisins-secs.jpg", InStock=true, IsTagineOfTheWeek=false, ImageThumbnailUrl="https://www.la-cuisine-marocaine.com/photos-recettes/Tajine-de-viande-aux-oignons-et-raisins-secs.jpg"},
                new Tagine {TagineId = 2, Name="Tagine poulet olives", Price=18.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://st4.depositphotos.com/4303215/25817/i/600/depositphotos_258175528-stock-photo-traditional-moroccan-tajine-of-chicken.jpg", InStock=true, IsTagineOfTheWeek=false, ImageThumbnailUrl="https://st4.depositphotos.com/4303215/25817/i/600/depositphotos_258175528-stock-photo-traditional-moroccan-tajine-of-chicken.jpg"},
                new Tagine {TagineId = 3, Name="Tagine legumes et olives", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://recettes.de/images/blogs/cuisine-test-recette-et-test-de-cuisine/tajine-poulet-legumes-avec-carottes-et-pois-chiches-257.640x480.jpg", InStock=true, IsTagineOfTheWeek=true, ImageThumbnailUrl="https://recettes.de/images/blogs/cuisine-test-recette-et-test-de-cuisine/tajine-poulet-legumes-avec-carottes-et-pois-chiches-257.640x480.jpg"},
                new Tagine {TagineId = 4, Name="Tagine boeuf legumes", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Tagine chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Tagine muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Tagine cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="http://www.lesfoodies.com/_recipeimage/71557/tajine-boeuf-legumes.jpg", InStock=true, IsTagineOfTheWeek=true, ImageThumbnailUrl="http://www.lesfoodies.com/_recipeimage/71557/tajine-boeuf-legumes.jpg"}
            };

      

       

        public IEnumerable<Tagine> TaginesOfTheWeek { get; }
        public Tagine GetTagineById(int tagineId)
        {
            return AllTagines.FirstOrDefault(p => p.TagineId == tagineId);
        }
    }
}