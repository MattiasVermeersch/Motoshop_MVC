using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wba.PE1.Webshop.Web.Models;
using PE1.Webshop.Domain;
using pe1.Webshop.Web.ViewModels;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace Wba.PE1.Webshop.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly MotorRepository motorRepository;

        public HomeController()
        {
            motorRepository = new MotorRepository();
        }

        [Route("/")]
        [Route("Home")]
        public IActionResult ShowMotors()
        {
            //declaring view model
            var viewModel = new HomeShowMotorsVM();

            //fill the viewmodel with motors to display on home screen
            viewModel.Motors = motorRepository.Motors;
            ViewBag.Message = "Webshop Motors";
            
            return View(viewModel);
        }

        [Route("Motors/{motorId}")]
        public IActionResult ShowMotorDetails(long motorId)
        {
            var viewModel = new HomeShowMotorDetailsVM();

            var motor = motorRepository.GetMotorById(motorId);

            if (motor == null)
                return NotFound();

            viewModel.Motor = motor;

            return View(viewModel);
        }

        [Route("Motors/PriceFilter")]
        public IActionResult FilterMotorsOnPrice()
        {
            ViewBag.Message = "All motors with price higher than € 10 000";
            var viewModel = new HomeShowMotorsVM
            {
                Motors = motorRepository.Motors.Where(m => m.Price > 10000)
            };

            return View("ShowMotors", viewModel);
        }

        [Route("Motors/CilinderFilter")]
        public IActionResult FilterMotorsOnCilinder()
        {
            ViewBag.Message = "All motors with engine displacement of 250 or lower";
            var viewModel = new HomeShowMotorsVM
            {
                Motors = motorRepository.Motors.Where(m => m.Cilinder < 251)
            };

            return View("ShowMotors", viewModel);
        }

        [Route("Motors/BrandFilter")]
        public IActionResult FilterMotorsOnBMW()
        {
            ViewBag.Message = "All BMW motors";
            var viewModel = new HomeShowMotorsVM
            {
                Motors = motorRepository.Motors.Where(m => m.Brand.Name == "BMW")
            };

            return View("ShowMotors", viewModel);
        }

        [Route("Motors/FuelTankFilter")]
        public IActionResult FilterMotorsOnFuelTank()
        {
            ViewBag.Message = "All motors with a fuel tank of at least 15 L";
            var viewModel = new HomeShowMotorsVM
            {
                Motors = motorRepository.Motors.Where(m => m.Fueltank >= 15)
            };

            return View("ShowMotors", viewModel);
        }

        [Route("Motors/BlackFilter")]
        public IActionResult FilterMotorsOnColorBlack()
        {
            ViewBag.Message = "All motors with a black color option";
            ViewBag.MyColor = "Black";
            var viewModel = new HomeShowMotorsVM
            {
                Motors = motorRepository.Motors.Where(m => m.Colors.Any(c => c.Name == "Black"))
            };

            return View("ShowMotors", viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
