using System;
using System.Collections.Generic;
using System.Text;

namespace PE1.Webshop.Domain
{
    public class BrandRepository
    {
        public IEnumerable<Brand> Brands { get; set; }
        public MotorRepository Motors { get; set; }

        public BrandRepository()
        {
            Brands = new List<Brand>
            {

            };
        }
    }
}
