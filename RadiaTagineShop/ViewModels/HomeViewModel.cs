using RadiaTagineShop.Models;
using System.Collections.Generic;

namespace RadiaTagineShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Tagine> TaginesOfTheWeek { get; set; }   
    }
}
