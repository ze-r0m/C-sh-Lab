using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Triangle : Figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public override double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public override Point GetCenter()
        {
            float x1 = 0, y1 = 0;
            float x2 = 0, y2 = 0;
            float x3 = (float)((b * b + c * c - a * a) / (2 * c)), y3 = (float)Math.Sqrt(b * b - x3 * x3);

            float x = (x1 + x2 + x3) / 3;
            float y = (y1 + y2 + y3) / 3;

            return new Point((int)(Position.X + x), (int)(Position.Y + y));
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawPolygon(new Pen(Color), new[]
            {
                new Point(Position.X, Position.Y),
                new Point((int)(Position.X + a), Position.Y),
                new Point(Position.X, (int)(Position.Y + b)),
            });
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
