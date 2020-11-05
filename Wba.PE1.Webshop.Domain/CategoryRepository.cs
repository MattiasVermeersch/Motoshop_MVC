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
                new Category{
                    Id=1, 
                    Name="Standard", 
                    Image="/images/categories/standard.JPG",
                    Description="The standard type of motorcycle is a common favorite because " +
                    "it has a simple design and is suited for all purposes. It has variations from " +
                    "125cc up to 1,000cc and can be fit with luggage, a tank bag, a different seat, " +
                    "and it makes a good first and all-around motorcycle to ride. It doesn’t normally " +
                    "come with a large fairing on the front if it has one at all. Ergonomics are pretty " +
                    "neutral as it isn’t very forward leaning or rearward reclining. Seat height usually " +
                    "is in the shorter to middle range and can usually fit almost everyone comfortably. "
                },
                new Category{
                    Id=2, 
                    Name="Cruiser", 
                    Image="/images/categories/cruiser.JPG",
                    Description="The cruiser, also nicknamed a chopper, was designed for cruising, " +
                    "hence, how it got its name. It typically has a little lower seat height, making " +
                    "it a good “cruising” around-town motorcycle, but with a little added luggage, it " +
                    "can make a good weekend rider. The engine sizes again are pretty varied from a small " +
                    "displacement engine through 1,000cc or more depending on the brand. You may feel more " +
                    "like you’re sitting in a cruiser than on it, but it’s a great option for both new and " +
                    "experienced riders. When you imagine a cruiser (specifically a chopper), Harley-Davidson " +
                    "may be the first brand that comes to mind."
                },
                new Category{
                    Id=3, 
                    Name="Sport Bike", 
                    Image="/images/categories/sport_bike.JPG",
                    Description="The sport genre of motorcycles are meant for speed and agility with forward-leaning " +
                    "ergonomics ready to carve some corners while riding. One of the largest differences with a Sport " +
                    "type motorcycle is their weight. They are generally one of the lighter motorcycles made from a " +
                    "lot of aluminum and lighter materials to increase the side to side maneuverability. The seat height " +
                    "is usually on the higher end to be able to lean the motorcycle farther without scraping foot pegs or " +
                    "fairings. Shorter riders may be on their tiptoes with the taller seat height."
                },
                new Category{
                    Id=4, 
                    Name="Touring", 
                    Image="/images/categories/touring.JPG",
                    Description="The Touring type of motorcycle is typically larger than most other motorcycles and " +
                    "it’s meant to have the amenities for cross-country touring to see the beaches on both coasts. " +
                    "They offer a large amount of storage with easy ergonomics that allow you to ride for hours at a time. " +
                    "They will have the largest fairings to block the wind and weather while riding. Engine sizes are " +
                    "typically large to be able to keep up highway speeds and haul a large amount of extra gear and extra clothes."
                },
                new Category{
                    Id=5, 
                    Name="Off-road", 
                    Image="/images/categories/off_road.JPG",
                    Description="Off-road motorcycles are exactly what they sound like: for going where no man has been before. " +
                    "They have taller seat heights to accommodate deeper brush and high suspension that can handle a few bumps " +
                    "along the way. They won’t typically have any lights or turn signals, so they will probably be trailered to " +
                    "the weekend riding spot. Most are pretty lightweight and ready to ride the back trails all weekend."
                }
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
