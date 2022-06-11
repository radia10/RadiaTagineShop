using System.Collections.Generic;

namespace RadiaTagineShop.Models
{
    public interface ITagineRepository
    {
        IEnumerable<Tagine> AllTagines { get; }
        IEnumerable<Tagine> TaginesOfTheWeek { get; }
        Tagine GetTagineById(int tagineId);
    }
}
