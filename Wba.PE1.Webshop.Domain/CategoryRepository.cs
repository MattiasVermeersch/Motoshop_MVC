using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PE1.Webshop.Domain
{
    public class CategoryRepository
    {
        public IEnumerable<Category> Categories { get; set; }
        public MotorRepository Motors { get; set; }

        public CategoryRepository()
        {
            Categories = new List<Category>
            {
                new Category{Id=1, Name="Standard", Image="/images/categories/standard.JPG"},
                new Category{Id=2, Name="Cruiser", Image="/images/categories/cruiser.JPG"},
                new Category{Id=3, Name="Sport Bike", Image="/images/categories/sport_bike.JPG"},
                new Category{Id=4, Name="Touring", Image="/images/categories/touring.JPG"},
                new Category{Id=5, Name="Off-road", Image="/images/categories/off_road.JPG"}
                //,
                //new Category{Id=5, Name="Sport Touring"},
                //new Category{Id=6, Name="Dual Sport"},
                //new Category{Id=7, Name="Scooter"},
                //new Category{Id=8, Name="Moped"}
            };
        }

        public Category GetCategoryById(long categoryId)
        {
            return Categories.FirstOrDefault(c => c.Id == categoryId);
        }
    }
}
