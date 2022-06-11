using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace RadiaTagineShop.Models
{
    public class TagineRepository : ITagineRepository
    {
        private readonly AppDbContext _appDbContext;
        public TagineRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public IEnumerable<Tagine> AllTagines
        {
            get { return _appDbContext.Tagines.Include(c=>c.Category); }   
        }
        public IEnumerable<Tagine> TaginesOfTheWeek
        {
            get { return _appDbContext.Tagines.Include(c => c.Category).Where(p =>p.IsTagineOfTheWeek); }
        }

        public Tagine GetTagineById(int tagineId)
        {
            return _appDbContext.Tagines.FirstOrDefault(p=>p.TagineId==tagineId);
        }
    }
}
