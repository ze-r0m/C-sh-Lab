using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Parallelogram : Figure
    {
        public double side { get; set; }
        public double angle { get; set; }
        public double height { get; set; }
        //По двум сторонам и углу между ними
        public override double GetArea()
        {
            return side * angle;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + side / 2), (int)(Position.Y + height / 2));
        }
        public override void Draw(Graphics gr)
        {
            double angleToRadians = angle * Math.PI / 180; 
            float x = (float)(height / Math.Tan(angleToRadians));


            gr.DrawPolygon(new Pen(Color), new[]
            {
                new Point(Position.X, Position.Y),
                new Point((int)(Position.X + side), Position.Y),
                new Point((int)(Position.X + side + x), (int)(Position.Y + height)),
                new Point((int)(Position.X + x), (int)(Position.Y + height))


        });
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
