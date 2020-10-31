using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace PE1.Webshop.Domain
{
    public class MotorRepository
    {
        public IEnumerable<Motor> Motors { get; set; }
        public CategoryRepository Categories { get; set; }
        public BrandRepository Brands { get; set; }
        public MotorRepository()
        {
            //https://www.motorcyclelegalfoundation.com/types-of-motorcycles/ types of motorcycles
            Motors = new List<Motor>
            {
                new Motor{}
            };
            
        }
    }
}
