using System.Collections.Generic;

namespace RadiaTagineShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Tagine> Tagines { get; set; }
    }
}
