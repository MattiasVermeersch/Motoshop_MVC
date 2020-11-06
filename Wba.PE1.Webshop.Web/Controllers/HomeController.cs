using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wba.PE1.Webshop.Web.Models;
using PE1.Webshop.Domain;
using pe1.Webshop.Web.ViewModels;

namespace Wba.PE1.Webshop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly CategoryRepository categoryRepository;
        private readonly BrandRepository brandRepository;
        private readonly MotorRepository motorRepository;

        public HomeController()
        {
            categoryRepository = new CategoryRepository();
            brandRepository = new BrandRepository();
            motorRepository = new MotorRepository();
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Webshop Motoren";
            return View();
        }

        [Route("/")]
        [Route("home")]
        public IActionResult ShowMotors()
        {
            //declaring view model
            var viewModel = new HomeShowMotorsVM();

            //fill the viewmodel with motors to display on home screen
            viewModel.Motors = motorRepository.Motors;

            return View(viewModel);
        }

        [Route("motors/{motorId}")]
        public IActionResult ShowMotorDetails(long motorId)
        {
            var viewModel = new HomeShowMotorDetailsVM();

            var motor = motorRepository.GetMotorById(motorId);

            if (motor == null)
                return NotFound();

            viewModel.Motor = motor;

            return View(viewModel);
        }

        [Route("categories")]
        public IActionResult ShowCategories()
        {
            var viewModel = new HomeShowCategoriesVM();

            viewModel.Categories = categoryRepository.Categories;

            return View(viewModel);
        }

        [Route("categories/{categoryId}/motors")]
        public IActionResult ShowMotorsInCategory(long categoryId)
        {
            var viewModel = new HomeShowMotorsInCategoryVM();

            Category category = categoryRepository.GetCategoryById(categoryId);

            if (category == null)
                return NotFound();

            viewModel.CategoryName = category.Name;
            viewModel.Motors = motorRepository.GetMotorsByCategoryId(categoryId);

            return View(viewModel);
        }

        [Route("brands")]
        public IActionResult ShowBrands()
        {
            var viewModel = new HomeShowBrandsVM();

            viewModel.Brands = brandRepository.Brands;

            return View(viewModel);
        }

        [Route("brands/{brandId}")]
        public IActionResult ShowBrandDetails(long brandId)
        {
            var viewModel = new HomeShowBrandDetailsVM();

            var brand = brandRepository.GetBrandById(brandId);

            if (brand == null)
                return NotFound();

            viewModel.Brand = brand;

            return View(viewModel);
        }

        [Route("brands/{brandId}/motors")]
        public IActionResult ShowMotorsInBrand(long brandId)
        {
            var viewModel = new HomeShowMotorsInBrandVM();

            Brand brand = brandRepository.GetBrandById(brandId);

            viewModel.BrandName = brand.Name;
            viewModel.Motors = motorRepository.GetMotorsByBrandId(brandId);

            return View(viewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
