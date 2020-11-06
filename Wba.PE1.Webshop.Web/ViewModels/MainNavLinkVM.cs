using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.ViewModels
{
    public class MainNavLinkVM
    {
        public string Text { get; set; } 
        public string Area { get; set; } 
        public string Controller { get; set; } 
        public string Action { get; set; } 
        public string Id { get; set; }
        public bool IsActive { get; set; }
    }
}
