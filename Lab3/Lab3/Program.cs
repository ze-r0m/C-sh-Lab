using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    class Program
    {
        public static Figure[] figures = { 
            new Rectangle()
            {
                Name = "Квадрат #1",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(30, 30),
                Width = 50, Height = 50
            },

            new Rectangle()
            {
                Name = "Квадрат #2",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(30, 100),
                Width = 100, Height = 100
            },

            new Rectangle()
            {
                Name = "Прямоугольник #1",
                Color = System.Drawing.Color.Blue,
                Position = new System.Drawing.Point(30, 250),
                Width = 100, Height = 50
            },
            new Circle()
            {
                Name = "Круг",
                Color = System.Drawing.Color.Orange,
                Position = new System.Drawing.Point(150, 30),
                d = 60
            },
            new Triangle()
            {
                Name ="Треугольник",
                Color = System.Drawing.Color.Silver,
                Position = new System.Drawing.Point(150, 100),
                a = 40, b = 60, c = 80
            },
            new Trapezoid()
            {
                Name = "Трапеция",
                Color= System.Drawing.Color.Brown,
                Position = new System.Drawing.Point(180, 150),
                height = 100, side1 = 160, side2 = 120
            }, 
            new Rhombus()
            {
                Name = "Ромб",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(280, 80),
                d1 = 60, d2 = 80
            },
            new Parallelogram()
            {
                Name = "Параллелограм",
                Color = System.Drawing.Color.DarkSlateGray,
                Position = new System.Drawing.Point(370, 30),
                side = 80, angle = 60, height = 40
            },
            new RegularPentagon()
            {
                Name = "Пентагон",
                Color = System.Drawing.Color.MediumVioletRed,
                Position = new System.Drawing.Point(500, 150),
                a = 80
            },
            new RegularDecagon()
            {
                Name = "Декагон",
                Color = System.Drawing.Color.DeepPink,
                Position = new System.Drawing.Point(500, 300),
                a = 80
            }
            
        };
            

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №3 - Полиморфизм");
            Console.WriteLine("Выполнил - Зеленский Роман");

            Form frm = new Form()
            {
                Text = "Лабораторная №3 - Полиморфизм",
                Size = new System.Drawing.Size(800, 600),
                StartPosition = FormStartPosition.CenterScreen
            };

            frm.Paint += Frm_Paint;

            Application.Run(frm);
        }
        private static void Frm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figures)
            {
                f.Draw(e.Graphics);
            }
        }
    }
}
