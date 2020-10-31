using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Text;

namespace Wba.PE1.Webshop.Domain
{
    public class Motor
    {
        public int Number { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Color> Color { get; set; }
        public int Cilinder { get; set; }
        public int Power { get; set; }
        public int Fuelconsumption { get; set; }
        public int Fueltank { get; set; }
        public string Chassistype { get; set; }
    }
}
