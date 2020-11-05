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
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public IEnumerable<string> Colors { get; set; }
        public int? Year { get; set; }
        public int Cilinder { get; set; }
        public string Power { get; set; }
        public double Fueltank { get; set; }
        public string Fueltype { get;set; }
        public double Price { get; set; }
        public IEnumerable<string> Image { get; set; }
    }
}
