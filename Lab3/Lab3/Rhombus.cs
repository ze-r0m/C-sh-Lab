using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    class Rhombus : Figure
    {
        public double d1 { get; set; }
        public double d2 { get; set; }

        public override double GetArea()
        {
            return d1 * d2  * 0.5;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + d1 /2), (int)Position.Y);
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawPolygon(new Pen(Color), new[]
            {
                new Point(Position.X, Position.Y),
                new Point((int)(Position.X + d1 / 2), (int)(Position.Y + (d2 / 2))),
                new Point((int)(Position.X + d1), Position.Y),
                new Point((int)(Position.X + d1 / 2), (int)(Position.Y - (d2 / 2))),
            });
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
