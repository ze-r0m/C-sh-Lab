using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Trapezoid : Figure
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double height { get; set; }

        public override double GetArea()
        {
            return (side1 + side2) * height/2;
        }
    }
}
