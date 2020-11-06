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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
