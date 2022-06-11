using RadiaTagineShop.Models;
using System.Collections.Generic;

namespace RadiaTagineShop.ViewModels
{
    public class TaginesListViewModel
    {
        public IEnumerable<Tagine> Tagines { get; set; }
        public string CurrentCategory { get; set; }
    }
}
