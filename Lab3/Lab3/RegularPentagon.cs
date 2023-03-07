using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class RegularPentagon : Figure
    {
        public double a { get; set; }
        public override double GetArea()
        {
            return Math.Pow(a, 2) * Math.Sqrt(25 + 10 * Math.Sqrt(5)) / 4;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X), (int)(Position.Y));
        }
        public override void Draw(Graphics gr)
        {
            double centralAngle = 2 * Math.PI / 5;

            gr.DrawPolygon(new Pen(Color), new[]
           {
                new Point((int) (Position.X + (float) (a * Math.Cos(1 * centralAngle - Math.PI / 2))), (int) (Position.Y + (float)(a * Math.Sin(1 * centralAngle - Math.PI / 2)))),
                new Point((int) (Position.X + (float) (a * Math.Cos(2 * centralAngle - Math.PI / 2))), (int) (Position.Y + (float)(a * Math.Sin(2 * centralAngle - Math.PI / 2)))),
                new Point((int) (Position.X + (float) (a * Math.Cos(3 * centralAngle - Math.PI / 2))), (int) (Position.Y + (float)(a * Math.Sin(3 * centralAngle - Math.PI / 2)))),
                new Point((int) (Position.X + (float) (a * Math.Cos(4 * centralAngle - Math.PI / 2))), (int) (Position.Y + (float)(a * Math.Sin(4 * centralAngle - Math.PI / 2)))),
                new Point((int) (Position.X + (float) (a * Math.Cos(5 * centralAngle - Math.PI / 2))), (int) (Position.Y + (float)(a * Math.Sin(5 * centralAngle - Math.PI / 2))))

            });
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
