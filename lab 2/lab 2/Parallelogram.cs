using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    
    class Parallelogram : Figure
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double angle { get; set; }
        //По двум сторонам и углу между ними
        public override double GetArea()
        {
            return side1 * side2 * Math.Sin(angle * Math.PI /180);
        }
    }
}
