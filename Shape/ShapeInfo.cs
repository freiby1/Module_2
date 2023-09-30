using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }

    class ShapeInfo
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите фигуру (1 - Круг, 2 - Прямоугольник, 3 - Треугольник, 0 - Выйти):");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    Console.WriteLine("Программа завершена.");
                    break;
                }

                Shape shape = null;

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите радиус круга: ");
                        double radius = double.Parse(Console.ReadLine());
                        shape = new Circle(radius);
                        break;

                    case 2:
                        Console.Write("Введите ширину прямоугольника: ");
                        double width = double.Parse(Console.ReadLine());

                        Console.Write("Введите высоту прямоугольника: ");
                        double height = double.Parse(Console.ReadLine());

                        shape = new Rectangle(width, height);
                        break;

                    case 3:
                        Console.Write("Введите основание треугольника: ");
                        double @base = double.Parse(Console.ReadLine());

                        Console.Write("Введите высоту треугольника: ");
                        double triHeight = double.Parse(Console.ReadLine());
                        shape = new Triangle(@base, triHeight);
                        break;

                    default:
                        Console.WriteLine("Выбрана неверная фигура.");
                        break;
                }

                if (shape != null)
                {
                    double area = shape.CalculateArea();
                    Console.WriteLine($"Площадь выбранной фигуры: {area}");
                }
            }
        }
    }
}