using System.Collections.Generic;

namespace RadiaTagineShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category { CategoryId = 1,CategoryName ="tagine de boeauf", Description="tous les tagines avec du boeuf"},
            new Category { CategoryId = 2,CategoryName ="tagine de poulet", Description="tous les tagines avec du poulet"},
            new Category { CategoryId = 3,CategoryName ="tagine de vegetarien", Description="tous les tagines vegetariens"},
        };
    }
}
