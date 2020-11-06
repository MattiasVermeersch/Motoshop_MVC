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
                new MainNavLinkVM{ Area=null, Controller="Category", Action="ShowMotorsInCategory", Id="1", Text="Standard"},
                new MainNavLinkVM{ Area=null, Controller="Category", Action="ShowMotorsInCategory", Id="2", Text="Cruiser"},
                new MainNavLinkVM{ Area=null, Controller="Category", Action="ShowMotorsInCategory", Id="3", Text="Sport Bike"},
                new MainNavLinkVM{ Area=null, Controller="Category", Action="ShowMotorsInCategory", Id="4", Text="Touring"},
                new MainNavLinkVM{ Area=null, Controller="Category", Action="ShowMotorsInCategory", Id="5", Text="Off-road"},
                new MainNavLinkVM{ Area=null, Controller="Category", Action="ShowCategories", Text="About Categories"},
                new MainNavLinkVM{ Area=null, Controller="Brand", Action="ShowBrands", Text="About Brands"}
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
