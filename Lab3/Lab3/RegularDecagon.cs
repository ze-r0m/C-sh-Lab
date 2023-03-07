using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class RegularDecagon : Figure
    {
        public double a { get; set; }
        public override double GetArea()
        {
            return (5 * Math.Pow(a, 2) * Math.Sqrt(5 + 2 * Math.Sqrt(5))) / 2;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X), (int)(Position.Y));
        }

        public override void Draw(Graphics gr)
        {
            double centralAngle = 2 * Math.PI / 10;
            Point[] points = new Point[10];
                for (int i = 0; i < 10; i++)
                {
                    points[i] = new Point(
                        (int)(Position.X + (float)(a * Math.Cos(i * centralAngle - Math.PI / 2))), (int)(Position.Y + (float)(a * Math.Sin(i * centralAngle - (Math.PI / 2))))
                    );
                }

            gr.DrawPolygon(new Pen(Color), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());



        }
    }
}
