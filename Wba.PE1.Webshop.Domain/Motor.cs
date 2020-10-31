using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Text;

namespace PE1.Webshop.Domain
{
    public class Motor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Color> Color { get; set; }
        public int Cilinder { get; set; }
        public int Power { get; set; }
        public int Fuelconsumption { get; set; }
        public int Fueltank { get; set; }
        public string Chassistype { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
