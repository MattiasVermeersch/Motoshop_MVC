using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pe1.Webshop.Web.ViewModels;
using PE1.Webshop.Domain;

namespace pe1.Webshop.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryRepository categoryRepository;
        private readonly MotorRepository motorRepository;

        public CategoryController()
        {
            categoryRepository = new CategoryRepository();
            motorRepository = new MotorRepository();
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("categories")]
        public IActionResult ShowCategories()
        {
            var viewModel = new CategoryShowCategoriesVM();

            viewModel.Categories = categoryRepository.Categories;

            return View(viewModel);
        }

        [Route("categories/{categoryId}/motors")]
        public IActionResult ShowMotorsInCategory(long categoryId)
        {
            var viewModel = new CategoryShowMotorsInCategoryVM();

            Category category = categoryRepository.GetCategoryById(categoryId);

            if (category == null)
                return NotFound();

            viewModel.CategoryName = category.Name;
            viewModel.Motors = motorRepository.GetMotorsByCategoryId(categoryId);

            return View(viewModel);
        }

    }
}
