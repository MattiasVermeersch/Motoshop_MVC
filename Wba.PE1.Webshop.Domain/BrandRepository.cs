using System;
using System.Collections.Generic;
using System.Linq;
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
                new Brand
                {
                    Id=1, 
                    Name="Honda",
                    Contactpage = "https://www.fl.honda.be/motorcycles/useful-links/contact-us.html",
                    Homepage = "https://www.fl.honda.be/motorcycles.html"
                },
                new Brand
                {
                    Id=2,
                    Name="Suzuki",
                    Contactpage="https://www.suzuki2wheels.be/nl/content/Contact.html",
                    Homepage="https://www.suzuki2wheels.be/nl.html?gclid=Cj0KCQjwlvT8BRDeARIsAACRFiWEKHwZL9qO0U909iTRUPgXEsR969GnCYdlOfPaeLRwKC-mKLhtSVwaAvXTEALw_wcB"
                },
                new Brand
                {
                    Id=3,
                    Name="Kawasaki",
                    Contactpage="https://www.kawasaki.be/nl/products/pages/Contact?Uid=0B12UAwKXlwKClENXlhQXA1aUAleCQsLUQkMX1hfCgldUAlGBgRFKi0",
                    Homepage="https://www.kawasaki.be/nl/products"
                },
                new Brand
                {
                    Id=4,
                    Name="Harley-Davidson",
                    Contactpage="https://www.harley-davidson.com/be/nl/customer-service/contact-us.html",
                    Homepage="https://www.harley-davidson.com/be/nl/index.html"
                },
                new Brand
                {
                    Id=5,
                    Name="BMW",
                    Contactpage="https://www.bmw-motorrad.be/nl/public-pool/content-pool/contact.html",
                    Homepage="https://www.bmw-motorrad.be/nl/models/modeloverview.html"
                }
            };
        }
        public Brand GetBrandById(long brandId)
        {
            return Brands.FirstOrDefault(s => s.Id == brandId);
        }
    }
}
