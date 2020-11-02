using PE1.Webshop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pe1.Webshop.Web.ViewModels
{
    public class HomeShowMotorsVM
    {
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Motor> Motors { get; set; }
    }
}
