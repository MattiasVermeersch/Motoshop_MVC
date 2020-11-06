using Microsoft.AspNetCore.Mvc;
using pe1.Webshop.Web.ViewModels;
using PE1.Webshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.Models.Components
{
    [ViewComponent(Name = "MainNavigation")]
    public class MainNavComponent : ViewComponent
    {
        private IEnumerable<MainNavLinkVM> publicLinks { get; set; }

        public MainNavComponent()
        {
            publicLinks = new List<MainNavLinkVM>
            {
                new MainNavLinkVM{ Area=null, Controller="Home", Action="ShowMotors", Text="Home"},
                new MainNavLinkVM{ Area=null, Controller="Category", Action="ShowCategories", Text="About Categories"},
                new MainNavLinkVM{ Area=null, Controller="Category", Action="ShowStandardMotors", Text="Category: Standard"},
                new MainNavLinkVM{ Area=null, Controller="Category", Action="ShowCruiserMotors", Text="Category: Cruiser"},
                new MainNavLinkVM{ Area=null, Controller="Category", Action="ShowSportBikeMotors", Text="Category: Sport Bike"},
                new MainNavLinkVM{ Area=null, Controller="Category", Action="ShowTouringMotors", Text="Category: Touring"},
                new MainNavLinkVM{ Area=null, Controller="Category", Action="ShowOffRoadMotors", Text="Category: Off-road"},
                new MainNavLinkVM{ Area=null, Controller="Brand", Action="ShowBrands", Text="About Brands"},
                new MainNavLinkVM{ Area=null, Controller="Home", Action="FilterMotorsOnPrice", Text="Filter: Price"},
                new MainNavLinkVM{ Area=null, Controller="Home", Action="FilterMotorsOnCilinder", Text="Filter: Cilinder"},
                new MainNavLinkVM{ Area=null, Controller="Home", Action="FilterMotorsOnBMW", Text="Filter: BMW"},
                new MainNavLinkVM{ Area=null, Controller="Home", Action="FilterMotorsOnFuelTank", Text="Filter: Fueltank"},
                new MainNavLinkVM{ Area=null, Controller="Home", Action="FilterMotorsOnColorBlack", Text="Filter: Black motors"},
            };
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var navLinks = publicLinks;

            foreach (var lnk in navLinks) 
            { 
                if (this.RouteData.Values["area"]?.ToString().ToLower() == lnk.Area?.ToLower() && 
                    this.RouteData.Values["controller"]?.ToString().ToLower() == lnk.Controller.ToLower() && 
                    this.RouteData.Values["action"]?.ToString().ToLower() == lnk.Action.ToLower())
                { 
                    lnk.IsActive = true; 
                } 
            }
            return await Task.FromResult<IViewComponentResult>(View(navLinks));
        }
    }
}
