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

        [Route("Categories")]
        public IActionResult ShowCategories()
        {
            var viewModel = new CategoryShowCategoriesVM();

            viewModel.Categories = categoryRepository.Categories;

            return View(viewModel);
        }

        [Route("Category/{categoryId:long}/Motors")]
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

        public IActionResult ShowStandardMotors()
        {
            var viewModel = new CategoryShowMotorsInCategoryVM();

            Category category = categoryRepository.GetCategoryById(1);

            if (category == null)
                return NotFound();

            viewModel.CategoryName = category.Name;
            viewModel.Motors = motorRepository.GetMotorsByCategoryId(1);

            return View("ShowMotorsInCategory", viewModel);
        }

        public IActionResult ShowCruiserMotors()
        {
            var viewModel = new CategoryShowMotorsInCategoryVM();

            Category category = categoryRepository.GetCategoryById(2);

            if (category == null)
                return NotFound();

            viewModel.CategoryName = category.Name;
            viewModel.Motors = motorRepository.GetMotorsByCategoryId(2);

            return View("ShowMotorsInCategory", viewModel);
        }

        public IActionResult ShowSportBikeMotors()
        {
            var viewModel = new CategoryShowMotorsInCategoryVM();

            Category category = categoryRepository.GetCategoryById(3);

            if (category == null)
                return NotFound();

            viewModel.CategoryName = category.Name;
            viewModel.Motors = motorRepository.GetMotorsByCategoryId(3);

            return View("ShowMotorsInCategory", viewModel);
        }

        public IActionResult ShowTouringMotors()
        {
            var viewModel = new CategoryShowMotorsInCategoryVM();

            Category category = categoryRepository.GetCategoryById(4);

            if (category == null)
                return NotFound();

            viewModel.CategoryName = category.Name;
            viewModel.Motors = motorRepository.GetMotorsByCategoryId(4);

            return View("ShowMotorsInCategory", viewModel);
        }

        public IActionResult ShowOffRoadMotors()
        {
            var viewModel = new CategoryShowMotorsInCategoryVM();

            Category category = categoryRepository.GetCategoryById(5);

            if (category == null)
                return NotFound();

            viewModel.CategoryName = category.Name;
            viewModel.Motors = motorRepository.GetMotorsByCategoryId(5);

            return View("ShowMotorsInCategory", viewModel);
        }
    }
}
