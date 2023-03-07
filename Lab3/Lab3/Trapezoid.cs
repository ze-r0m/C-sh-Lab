using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Trapezoid : Figure
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double height { get; set; }

        public override double GetArea()
        {
            return (side1 + side2) * height / 2;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + (side2 / 2)), (int)(Position.Y + (height / 2)));
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawPolygon(new Pen(Color), new[]
            {
                new Point(Position.X, Position.Y),
                new Point((int)(Position.X + side2), Position.Y),
                new Point((int)(Position.X +  side1), (int)(Position.Y + height)),
                new Point((int)(Position.X + ((side2 - side1) / 2)), (int)(Position.Y + height))

               
        });
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
