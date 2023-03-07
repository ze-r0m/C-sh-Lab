using Lab3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Circle : Figure
    {
        public double d { get; set; }

        public override double GetArea()
        {
            return Math.PI * Math.Pow((d / 2), 2);
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + d / 2), (int)(Position.Y + d / 2));
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color), Position.X, Position.Y, (int)d, (int)d);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }

}
