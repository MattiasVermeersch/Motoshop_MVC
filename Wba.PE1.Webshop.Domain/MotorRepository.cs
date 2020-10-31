using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Wba.PE1.Webshop.Domain
{
    public class MotorRepository
    {
        public IEnumerable<Motor> GetMotors()
        {
            //https://www.motorcyclelegalfoundation.com/types-of-motorcycles/ types of motorcycles
            return new List<Motor>
            {
                new Motor
                { 
                    
                }
            };
            
        }
    }
}
