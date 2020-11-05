using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
                        "/images/honda/cb500f/red.jpg",
                        "/images/honda/cb500f/black.jpg",
                        "/images/honda/cb500f/blue.jpg",
                        "/images/honda/cb500f/orange.jpg"
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
                        "/images/honda/cb125r/black.jpg",
                        "/images/honda/cb125r/grey.jpg",
                        "/images/honda/cb125r/white.jpg",
                        "/images/honda/cb125r/red.jpg"
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
                        "/images/honda/cb1000r/white.jpg",
                        "/images/honda/cb1000r/black.jpg",
                        "/images/honda/cb1000r/red.jpg"
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
                        "/images/honda/cbr500r/red.jpg",
                        "/images/honda/cbr500r/black.jpg",
                        "/images/honda/cbr500r/white.jpg"
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
                        "/images/honda/cbr1000rr-r_fireblade/red.jpg",
                        "/images/honda/cbr1000rr-r_fireblade/black.jpg"
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
                        "/images/honda/gold_wing_tour/red.jpg",
                        "/images/honda/gold_wing_tour/black.jpg"
                    }
                },
                //Suzuki motors
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
                        "/images/suzuki/gsx-s125/red.jpg",
                        "/images/suzuki/gsx-s125/blue.jpg"
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
                        "/images/suzuki/katana/silver.jpg",
                        "/images/suzuki/katana/black.jpg"
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
                        "/images/suzuki/gsx-r125/blue.jpg"
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
                        "/images/suzuki/gsx-r1000/white.jpg",
                        "/images/suzuki/gsx-r1000/blue.jpg",
                        "/images/suzuki/gsx-r1000/black.jpg"
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
                        "/images/suzuki/v-strom_650/grey.jpg",
                        "/images/suzuki/v-strom_650/black.jpg",
                        "/images/suzuki/v-strom_650/white.jpg"
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
                        "/images/suzuki/v-strom_1050xt/orange.jpg",
                        "/images/suzuki/v-strom_1050xt/yellow.jpg",
                        "/images/suzuki/v-strom_1050xt/black.jpg"
                    }
                },
                //Kawasaki motors
                new Motor
                {
                    Id=13,
                    Name="Ninja H2 Carbon",
                    Brand=BrandRepository.GetBrandById(3),
                    Category=CategoryRepository.GetCategoryById(3),
                    Colors= new List<string>
                    {
                        "Black"
                    },
                    Year=2018,
                    Cilinder=998,
                    Power="150.8 kW (205pk) / 11000 tpm",
                    Fueltank=17,
                    Fueltype="Benzine",
                    Price=31500,
                    Image = new List<string>
                    {
                        "/images/kawasaki/ninja_h2_carbon/black.png"
                    }
                },
                new Motor
                {
                    Id=14,
                    Name="Ninja ZX-10R SE",
                    Brand=BrandRepository.GetBrandById(3),
                    Category=CategoryRepository.GetCategoryById(3),
                    Colors= new List<string>
                    {
                        "Silver"
                    },
                    Year=2018,
                    Cilinder=998,
                    Power="149.3 kW (203pk) / 13500 tpm",
                    Fueltank=17,
                    Fueltype="Benzine",
                    Price=23499,
                    Image = new List<string>
                    {
                        "/images/kawasaki/ninja_zx-10r_se/silver.png"
                    }
                },
                new Motor
                {
                    Id=15,
                    Name="Vulcan S Cafe Tourer",
                    Brand=BrandRepository.GetBrandById(3),
                    Category=CategoryRepository.GetCategoryById(2),
                    Colors= new List<string>
                    {
                        "Orange"
                    },
                    Year=2019,
                    Cilinder=649,
                    Power="45 kW (61pk) / 7500 tpm",
                    Fueltank=14,
                    Fueltype="Benzine",
                    Price=999,
                    Image = new List<string>
                    {
                        "/images/kawasaki/vulcan_s_cafe_tourer/orange.png"
                    }
                },
                new Motor
                {
                    Id=16,
                    Name="Vulcan S Performance",
                    Brand=BrandRepository.GetBrandById(3),
                    Category=CategoryRepository.GetCategoryById(2),
                    Colors= new List<string>
                    {
                        "Grey",
                        "Green"
                    },
                    Year=2019,
                    Cilinder=1700,
                    Power="45 kW (61pk) / 7500 tpm",
                    Fueltank=14,
                    Fueltype="Benzine",
                    Price=7649,
                    Image = new List<string>
                    {
                        "/images/kawasaki/vulcan_s_performance/grey.png",
                        "/images/kawasaki/vulcan_s_performance/green.png"
                    }
                },
                //Harley-Davidson motors
                new Motor
                {
                    Id=17,
                    Name="Fat Bob",
                    Brand=BrandRepository.GetBrandById(4),
                    Category=CategoryRepository.GetCategoryById(2),
                    Colors= new List<string>
                    {
                        "Red",
                        "Black"
                    },
                    Year=2020,
                    Cilinder=1746,
                    Power="69 kW (93pk) / 5020 tpm",
                    Fueltank=14,
                    Fueltype="Benzine",
                    Price=18100,
                    Image = new List<string>
                    {
                        "/images/harley_davidson/fat_bob/red.JPG",
                        "/images/harley_davidson/fat_bob/black.JPG"
                    }
                },
                new Motor
                {
                    Id=18,
                    Name="Low Rider S",
                    Brand=BrandRepository.GetBrandById(4),
                    Category=CategoryRepository.GetCategoryById(2),
                    Colors= new List<string>
                    {
                        "Black",
                        "Silver"
                    },
                    Year=2020,
                    Cilinder=1868,
                    Power="93pk / 5020 tpm",
                    Fueltank=18.9,
                    Fueltype="Benzine",
                    Price=20000,
                    Image = new List<string>
                    {
                        "/images/harley_davidson/low_rider_s/black.JPG",
                        "/images/harley_davidson/low_rider_s/silver.JPG"
                    }
                },
                new Motor
                {
                    Id=19,
                    Name="Fat Boy",
                    Brand=BrandRepository.GetBrandById(4),
                    Category=CategoryRepository.GetCategoryById(2),
                    Colors= new List<string>
                    {
                        "Red",
                        "Silver",
                        "Blue",
                        "Black"
                    },
                    Year=2020,
                    Cilinder=1868,
                    Power="69kW (93pk) / 5020 tpm",
                    Fueltank=18.9,
                    Fueltype="Benzine",
                    Price=22200,
                    Image = new List<string>
                    {
                        "/images/harley_davidson/fat_boy/red.JPG",
                        "/images/harley_davidson/fat_boy/silver.JPG",
                        "/images/harley_davidson/fat_boy/blue.JGP",
                        "/images/harley_davidson/fat_boy/black.JPG"
                    }
                },
                new Motor
                {
                    Id=20,
                    Name="Softail Standard",
                    Brand=BrandRepository.GetBrandById(4),
                    Category=CategoryRepository.GetCategoryById(2),
                    Colors= new List<string>
                    {
                        "Black"
                    },
                    Year=2020,
                    Cilinder=1746,
                    Power="N/A",
                    Fueltank=13.2,
                    Fueltype="Benzine",
                    Price=13795,
                    Image = new List<string>
                    {
                        "/images/harley_davidson/softail_standard/black.JPG"
                    }
                },
                new Motor
                {
                    Id=21,
                    Name="Road King",
                    Brand=BrandRepository.GetBrandById(4),
                    Category=CategoryRepository.GetCategoryById(4),
                    Colors= new List<string>
                    {
                        "Black",
                        "Red",
                        "White"
                    },
                    Year=2020,
                    Cilinder=1746,
                    Power="N/A",
                    Fueltank=22.7,
                    Fueltype="Benzine",
                    Price=25100,
                    Image = new List<string>
                    {
                        "/images/harley_davidson/road_king/black.JPG",
                        "/images/harley_davidson/road_king/red.JPG",
                        "/images/harley_davidson/road_king/white.JPG"
                    }
                },
                //BMW
                new Motor
                {
                    Id=22,
                    Name="F 900 XR",
                    Brand=BrandRepository.GetBrandById(5),
                    Category=CategoryRepository.GetCategoryById(5),
                    Colors= new List<string>
                    {
                        "Red",
                        "White",
                        "Yellow"
                    },
                    Year=2020,
                    Cilinder=895,
                    Power="77kW (105pk) / 8500 tpm",
                    Fueltank=15.5,
                    Fueltype="Benzine",
                    Price=11450,
                    Image = new List<string>
                    {
                        "/images/bmw/f_900_xr/red.jpg",
                        "/images/bmw/f_900_xr/white.jpg",
                        "/images/bmw/f_900_xr/yellow.jpg"
                    }
                },
                new Motor
                {
                    Id=23,
                    Name="R 1250 GS",
                    Brand=BrandRepository.GetBrandById(5),
                    Category=CategoryRepository.GetCategoryById(5),
                    Colors= new List<string>
                    {
                        "Black",
                        "White",
                        "Blue",
                        "Yellow"
                    },
                    Year=2020,
                    Cilinder=1254,
                    Power="100kW (136pk) / 7750 tpm",
                    Fueltank=20,
                    Fueltype="Benzine",
                    Price=17290,
                    Image = new List<string>
                    {
                        "/images/bmw/r_1250_gs/black.jpg",
                        "/images/bmw/r_1250_gs/white.jpg",
                        "/images/bmw/r_1250_gs/blue.jpg",
                        "/images/bmw/r_1250_gs/yellow.jpg"
                    }
                },
                new Motor
                {
                    Id=24,
                    Name="K 1600 GTL",
                    Brand=BrandRepository.GetBrandById(5),
                    Category=CategoryRepository.GetCategoryById(4),
                    Colors= new List<string>
                    {
                        "Brown",
                        "Black",
                        "White"
                    },
                    Year=2020,
                    Cilinder=1649,
                    Power="118kW (160pk) / 7750 tpm",
                    Fueltank=26.5,
                    Fueltype="Benzine",
                    Price=28300,
                    Image = new List<string>
                    {
                        "/images/bmw/k_1600_gtl/brown.jpg",
                        "/images/bmw/k_1600_gtl/black.jpg",
                        "/images/bmw/k_1600_gtl/white.jpg"
                    }
                },
                new Motor
                {
                    Id=25,
                    Name="R 1250 RT",
                    Brand=BrandRepository.GetBrandById(5),
                    Category=CategoryRepository.GetCategoryById(4),
                    Colors= new List<string>
                    {
                        "Brown",
                        "Blue",
                        "Silver"
                    },
                    Year=2020,
                    Cilinder=1254,
                    Power="100kW (136pk) / 7750 tpm",
                    Fueltank=25,
                    Fueltype="Benzine",
                    Price=19720,
                    Image = new List<string>
                    {
                        "/images/bmw/r_1250_rt/brown.jpg",
                        "/images/bmw/r_1250_rt/blue.jpg",
                        "/images/bmw/r_1250_rt/silver.jpg"
                    }
                },
                new Motor
                {
                    Id=26,
                    Name="K 1600 B",
                    Brand=BrandRepository.GetBrandById(5),
                    Category=CategoryRepository.GetCategoryById(4),
                    Colors= new List<string>
                    {
                        "Silver",
                        "Red",
                        "Black"
                    },
                    Year=2020,
                    Cilinder=1649,
                    Power="118kW (160pk) / 7750 tpm",
                    Fueltank=26.5,
                    Fueltype="Benzine",
                    Price=26150,
                    Image = new List<string>
                    {
                        "/images/bmw/k_1600_b/silver.jpg",
                        "/images/bmw/k_1600_b/red.jpg",
                        "/images/bmw/k_1600_b/black.jpg"
                    }
                },
                new Motor
                {
                    Id=27,
                    Name="R 1250 RS",
                    Brand=BrandRepository.GetBrandById(5),
                    Category=CategoryRepository.GetCategoryById(3),
                    Colors= new List<string>
                    {
                        "Black",
                        "Yellow",
                        "Blue"
                    },
                    Year=2020,
                    Cilinder=1254,
                    Power="100kW / 7750 tpm",
                    Fueltank=18,
                    Fueltype="Benzine",
                    Price=15260,
                    Image = new List<string>
                    {
                        "/images/bmw/r_1250_rs/black.jpg",
                        "/images/bmw/r_1250_rs/yellow.jpg",
                        "/images/bmw/r_1250_rs/blue.jpg"
                    }
                }
            };
        }

        public Motor GetMotorById(long motorId)
        {
            return Motors.FirstOrDefault(m => m.Id == motorId);
        }

        public IEnumerable<Motor> GetMotorsByBrandId(long brandId)
        {
            return Motors.Where(m => m.Brand.Id == brandId);
        }

        public IEnumerable<Motor> GetMotorsByCategoryId(long categoryId)
        {
            return Motors.Where(m => m.Category.Id == categoryId);
        }
    }
}
