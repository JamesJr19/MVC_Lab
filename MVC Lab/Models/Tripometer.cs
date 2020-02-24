using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Lab.Models
{
    public class Tripometer
    {
        public double MPG { get; set; }
        public double Gallons { get; set; }
        public double Trip { get; set; }
        public double Range { get; set; }

        public double Ranged()
        {
            return MPG * Gallons;
        }
    }
}
