using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pe1.Webshop.Web.ViewModels;
using PE1.Webshop.Domain;

namespace pe1.Webshop.Web.Controllers
{
    public class BrandController : Controller
    {
        private readonly BrandRepository brandRepository;
        private readonly MotorRepository motorRepository;

        public BrandController()
        {
            brandRepository = new BrandRepository();
            motorRepository = new MotorRepository();
        }
        public IActionResult Index()
        {
            return View();
        }


        [Route("brands")]
        public IActionResult ShowBrands()
        {
            var viewModel = new BrandShowBrandsVM();

            viewModel.Brands = brandRepository.Brands;

            return View(viewModel);
        }

        [Route("brands/{brandId}/motors")]
        public IActionResult ShowMotorsInBrand(long brandId)
        {
            var viewModel = new BrandShowMotorsInBrandVM();

            Brand brand = brandRepository.GetBrandById(brandId);

            viewModel.BrandName = brand.Name;
            viewModel.Motors = motorRepository.GetMotorsByBrandId(brandId);

            return View(viewModel);
        }
    }
}
