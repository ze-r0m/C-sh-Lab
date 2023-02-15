using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная №2 - Наследование");
            Console.WriteLine("Выполнил - Зеленский Роман");

            //Создаем прямоугольники А и Б и на месте зададим их параметры
            Rectangle a = new Rectangle()
            {
                Name = "Прямоугольник А", Width = 15.2, Height = 13.7
            };
            Rectangle b = new Rectangle()
            {
                Name = "Прямоугольник Б", Width = 5.1, Height = 2.8
            };

            // Выведем информацию о прямоугольнике
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", a.Name);
            Console.WriteLine("Площадь фигуры: {0}", a.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", b.Name);
            Console.WriteLine("Площадь фигуры: {0}", b.GetArea());

            //Создадим круг с, зададим параметры и выведем
            Circle c = new Circle()
            {
                Name = "Круг с", Radius = 10
            };
            Console.WriteLine() ;
            Console.WriteLine("Название фигуры: {0}", c.Name);
            Console.WriteLine("Площадь фигуры: {0}", c.GetArea());

            //Создадим трапецию t, зададим параметры и выведем
            Trapezoid t = new Trapezoid()
            {
                Name = "Трапеция t", height = 10, side1 = 12, side2 = 16
            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", t.Name);
            Console.WriteLine("Площадь фигуры: {0}", t.GetArea());

            //Создадим ромб r, зададим параметры и выведем
            Rhombus r = new Rhombus()
            {
                Name = "Трапеция r", side = 10, height = 15
            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", r.Name);
            Console.WriteLine("Площадь фигуры: {0}", r.GetArea());

            //Создадим параллелограмм p, зададим параметры и выведем
            Parallelogram p = new Parallelogram()
            {
                Name = "Параллелограмм p", side1 = 5, side2 = 6, angle = 22
            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", p.Name);
            Console.WriteLine("Площадь фигуры: {0}", p.GetArea());

            //Создадим правильный пятиугольник p5, зададим параметры и выведем
            RegPolygon p5 = new RegPolygon()
            { 
                Name ="Правильный пятиугольник p5", A = 6, N = 5
            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", p5.Name);
            Console.WriteLine("Площадь фигуры: {0}", p5.GetArea());

            //Создадим правильный десятиугольник p10, зададим параметры и выведем
            RegPolygon p10 = new RegPolygon()
            {
                Name = "Правильный пятиугольник p10", A = 6, N = 10
            };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", p10.Name);
            Console.WriteLine("Площадь фигуры: {0}", p10.GetArea());
        }
    }
}
