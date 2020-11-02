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
                new Category{Id=1, Name="Standard"},
                new Category{Id=2, Name="Cruiser"},
                new Category{Id=3, Name="Sport Bike"},
                new Category{Id=4, Name="Touring"},
                new Category{Id=5, Name="Off-road"}
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
