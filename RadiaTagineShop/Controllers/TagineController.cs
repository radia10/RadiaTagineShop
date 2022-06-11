using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RadiaTagineShop.Models;
using RadiaTagineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RadiaTagineShop.Controllers
{
    public class TagineController : Controller
    {
        private readonly ITagineRepository _tagineRepository;
        private readonly ICategoryRepository _categoryRepository;
        

        public TagineController(ICategoryRepository categoryRepository, ITagineRepository tagineRepository)
        {
            _tagineRepository = tagineRepository;
            _categoryRepository = categoryRepository;
        }
        //public ViewResult List()
        //{
        //    TaginesListViewModel taginesListViewModel = new TaginesListViewModel();
        //    taginesListViewModel.Tagines = _tagineRepository.AllTagines;
        //    taginesListViewModel.CurrentCategory = "Tagine boeuf";
        //    return View(taginesListViewModel);
        //}



        public ViewResult List(string category)
        {
            IEnumerable<Tagine> Tagines;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                Tagines = _tagineRepository.AllTagines.OrderBy(p => p.TagineId);
                currentCategory = "All Tagines";
            }
            else
            {
                Tagines = _tagineRepository.AllTagines.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.TagineId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new TaginesListViewModel
            {
                Tagines = Tagines,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var tagine=_tagineRepository.GetTagineById(id);
            if (tagine == null)
                return NotFound();
            return View(tagine);
        }

       
    }
}
