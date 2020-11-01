using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Schema;

namespace PE1.Webshop.Domain
{
    public class MotorRepository
    {
        public IEnumerable<Motor> Motors { get; set; }
        public CategoryRepository CategoryRepository { get; set; }
        public BrandRepository BrandRepository { get; set; }
        public MotorRepository()
        {
            BrandRepository = new BrandRepository();
            CategoryRepository = new CategoryRepository();
            //https://www.motorcyclelegalfoundation.com/types-of-motorcycles/ types of motorcycles
            Motors = new List<Motor>
            {
                //Honda motor
                new Motor
                {
                    Id=1,
                    Name="CB500F",
                    Brand=BrandRepository.GetBrandById(1),
                    Category=CategoryRepository.GetCategoryById(1),
                    Colors=new List<string>
                    {
                        "Red",
                        "Black",
                        "Blue",
                        "Orange"
                    },
                    Year=2019,
                    Cilinder=471,
                    Power="47 PK (35 kW) @ 8600 tpm",
                    Fueltank=17.1,
                    Fueltype="Benzine",
                    Price=6399,
                    Image=new List<string>
                    {
                        "~/images/honda/cb500f/red.jpg",
                        "~/images/honda/cb500f/black.jpg",
                        "~/images/honda/cb500f/blue.jpg",
                        "~/images/honda/cb500f/orange.jpg"
                    }
                },
                new Motor
                {
                    Id=2,
                    Name="CB125R",
                    Brand=BrandRepository.GetBrandById(1),
                    Category=CategoryRepository.GetCategoryById(1),
                    Colors=new List<string>
                    {
                        "Black",
                        "Grey",
                        "White",
                        "Red"
                    },
                    Year=2018,
                    Cilinder=125,
                    Power="9.8kw/10000tpm",
                    Fueltank=10.1,
                    Fueltype="Benzine",
                    Price=4399,
                    Image=new List<string>
                    {
                        "~/images/honda/cb125r/black.jpg",
                        "~/images/honda/cb125r/grey.jpg",
                        "~/images/honda/cb125r/white.jpg",
                        "~/images/honda/cb125r/red.jpg"
                    }
                },
                new Motor
                {
                    Id=3,
                    Name="CB1000R",
                    Brand=BrandRepository.GetBrandById(1),
                    Category=CategoryRepository.GetCategoryById(1),
                    Colors= new List<string>
                    {
                        "White",
                        "Black",
                        "Red"
                    },
                    Year=2020,
                    Cilinder=998,
                    Power="107kW @ 10,500tpm",
                    Fueltank=16.2,
                    Fueltype="Benzine",
                    Price=13599,
                    Image = new List<string>
                    {
                        "~/images/honda/cb1000r/white.jpg",
                        "~/images/honda/cb1000r/black.jpg",
                        "~/images/honda/cb1000r/red.jpg"
                    }
                },
                new Motor
                {
                    Id=4,
                    Name="CBR500R",
                    Brand=BrandRepository.GetBrandById(1),
                    Category=CategoryRepository.GetCategoryById(3),
                    Colors= new List<string>
                    {
                        "Red",
                        "Black",
                        "White"
                    },
                    Year=2019,
                    Cilinder=471,
                    Power="47 PK (35 kW) @ 8600 tpm",
                    Fueltank=17.1,
                    Fueltype="Benzine",
                    Price=6899,
                    Image = new List<string>
                    {
                        "~/images/honda/cbr500r/red.jpg",
                        "~/images/honda/cbr500r/black.jpg",
                        "~/images/honda/cbr500r/white.jpg"
                    }
                },
                new Motor
                {
                    Id=5,
                    Name="CBR1000RR-R Fireblade",
                    Brand=BrandRepository.GetBrandById(1),
                    Category=CategoryRepository.GetCategoryById(3),
                    Colors= new List<string>
                    {
                        "Red",
                        "Black"
                    },
                    Year=2020,
                    Cilinder=999,
                    Power="217,6 PK (160kW) bij 14.500 tpm",
                    Fueltank=16.1,
                    Fueltype="Benzine",
                    Price=21699,
                    Image = new List<string>
                    {
                        "~/images/honda/cbr1000rr-r_fireblade/red.jpg",
                        "~/images/honda/cbr1000rr-r_fireblade/black.jpg"
                    }
                },
                new Motor
                {
                    Id=6,
                    Name="Gold Wing Tour",
                    Brand=BrandRepository.GetBrandById(1),
                    Category=CategoryRepository.GetCategoryById(4),
                    Colors= new List<string>
                    {
                        "Red",
                        "Black"
                    },
                    Year=2020,
                    Cilinder=1833,
                    Power="93kW/5500tpm",
                    Fueltank=21.1,
                    Fueltype="Benzine",
                    Price=32999,
                    Image = new List<string>
                    {
                        "~/images/honda/gold_wing_tour/red.jpg",
                        "~/images/honda/gold_wing_tour/black.jpg"
                    }
                },
                new Motor
                {
                    Id=7,
                    Name="GSX-S125",
                    Brand=BrandRepository.GetBrandById(2),
                    Category=CategoryRepository.GetCategoryById(1),
                    Colors= new List<string>
                    {
                        "Red",
                        "Blue"
                    },
                    Year=2020,
                    Cilinder=124,
                    Power="15pk/11kW",
                    Fueltank=11,
                    Fueltype="Benzine",
                    Price=3999,
                    Image = new List<string>
                    {
                        "~/images/suzuki/gsx-s125/red.jpg",
                        "~/images/suzuki/gsx-s125/blue.jpg"
                    }
                },
                new Motor
                {
                    Id=8,
                    Name="Katana",
                    Brand=BrandRepository.GetBrandById(2),
                    Category=CategoryRepository.GetCategoryById(1),
                    Colors= new List<string>
                    {
                        "Silver",
                        "Black"
                    },
                    Year=2020,
                    Cilinder=999,
                    Power="150 pk @ 10.000 tpm",
                    Fueltank=12,
                    Fueltype="Benzine",
                    Price=13999,
                    Image = new List<string>
                    {
                        "~/images/suzuki/katana/silver.jpg",
                        "~/images/suzuki/katana/black.jpg"
                    }
                },
                new Motor
                {
                    Id=9,
                    Name="GSX-R125",
                    Brand=BrandRepository.GetBrandById(2),
                    Category=CategoryRepository.GetCategoryById(3),
                    Colors= new List<string>
                    {
                        "Blue"
                    },
                    Year=2020,
                    Cilinder=124,
                    Power="11kW",
                    Fueltank=11,
                    Fueltype="Benzine",
                    Price=4499,
                    Image = new List<string>
                    {
                        "~/images/suzuki/gsx-r125/blue.jpg"
                    }
                },
                new Motor
                {
                    Id=10,
                    Name="GSX-R1000",
                    Brand=BrandRepository.GetBrandById(2),
                    Category=CategoryRepository.GetCategoryById(3),
                    Colors= new List<string>
                    {
                        "White",
                        "Blue",
                        "Black"
                    },
                    Year=2020,
                    Cilinder=999,
                    Power="202pk",
                    Fueltank=16,
                    Fueltype="Benzine",
                    Price=16999,
                    Image = new List<string>
                    {
                        "~/images/suzuki/gsx-r1000/white.jpg",
                        "~/images/suzuki/gsx-r1000/blue.jpg",
                        "~/images/suzuki/gsx-r1000/black.jpg"
                    }
                },
                new Motor
                {
                    Id=11,
                    Name="V-Strom 650",
                    Brand=BrandRepository.GetBrandById(2),
                    Category=CategoryRepository.GetCategoryById(5),
                    Colors= new List<string>
                    {
                        "Grey",
                        "Black",
                        "White"
                    },
                    Year=2020,
                    Cilinder=645,
                    Power="71pk / 8800rpm",
                    Fueltank=20,
                    Fueltype="Benzine",
                    Price=8299,
                    Image = new List<string>
                    {
                        "~/images/suzuki/v-strom_650/grey.jpg",
                        "~/images/suzuki/v-strom_650/black.jpg",
                        "~/images/suzuki/v-strom_650/white.jpg"
                    }
                },
                new Motor
                {
                    Id=12,
                    Name="V-Strom 1050XT",
                    Brand=BrandRepository.GetBrandById(2),
                    Category=CategoryRepository.GetCategoryById(5),
                    Colors= new List<string>
                    {
                        "Orange",
                        "Yellow",
                        "Black"
                    },
                    Year=2020,
                    Cilinder=1037,
                    Power="79 kW(107.6 pk)/8500 tpm",
                    Fueltank=20,
                    Fueltype="Benzine",
                    Price=14599,
                    Image = new List<string>
                    {
                        "~/images/suzuki/v-strom_1050xt/orange.jpg",
                        "~/images/suzuki/v-strom_1050xt/yellow.jpg",
                        "~/images/suzuki/v-strom_1050xt/black.jpg"
                    }
                }
            };
            
        }
    }
}
