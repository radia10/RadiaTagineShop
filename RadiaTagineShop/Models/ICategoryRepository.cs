using System.Collections.Generic;

namespace RadiaTagineShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
