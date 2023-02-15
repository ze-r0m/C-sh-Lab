using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Rhombus : Figure
    {
        public double side { get; set; }
        public double height { get; set;}

        public override double GetArea()
        {
            return side * height;
        }
    }
}
