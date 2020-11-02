using Microsoft.AspNetCore.Mvc;
using pe1.Webshop.Web.ViewModels;
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
                new MainNavLinkVM{ Area=null, Controller="Home", Action="ShowCategories", Text="Categories"}
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
