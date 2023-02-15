using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class RegPolygon : Figure
    {
        public double N { get; set; } // количество сторон фигуры
        public double A { get; set; } // длина сторон

        public override double GetArea()
        {
            double apothem = A / (2 * Math.Tan(Math.PI / N));
            double area = 0.5 * N * A * apothem;
            return area;
        }
        
    }
}
