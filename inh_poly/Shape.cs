using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inh_poly
{
    // Базовый класс для геометрических фигур
    class Shape
    {
        // Метод для расчета площади
        public virtual double Area()
        {
            return 0;
        }

        // Метод для расчета периметра
        public virtual double Perimeter()
        {
            return 0;
        }
    }

    // Производный класс для круга
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Переопределяем метод Area() для круга
        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        // Переопределяем метод Perimeter() для круга
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    // Производный класс для прямоугольника
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // Переопределяем метод Area() для прямоугольника
        public override double Area()
        {
            return length * width;
        }

        // Переопределяем метод Perimeter() для прямоугольника
        public override double Perimeter()
        {
            return 2 * (length + width);
        }
    }

    class Inh_poly
    {
        static void Main()
        {
            // Запросите пользователя ввести данные для круга
            Console.Write("Введите радиус круга: ");
            double circleRadius = double.Parse(Console.ReadLine());

            // Запросите пользователя ввести данные для прямоугольника
            Console.Write("Введите длину прямоугольника: ");
            double rectangleLength = double.Parse(Console.ReadLine());

            Console.Write("Введите ширину прямоугольника: ");
            double rectangleWidth = double.Parse(Console.ReadLine());

            // Создайте объекты классов с введенными данными
            Circle circle = new Circle(circleRadius);
            Rectangle rectangle = new Rectangle(rectangleLength, rectangleWidth);

            // Выводим площади и периметры всех фигур
            Console.WriteLine("Площадь и периметр круга:");
            Console.WriteLine("Площадь: " + circle.Area());
            Console.WriteLine("Периметр: " + circle.Perimeter());

            Console.WriteLine();

            Console.WriteLine("Площадь и периметр прямоугольника:");
            Console.WriteLine("Площадь: " + rectangle.Area());
            Console.WriteLine("Периметр: " + rectangle.Perimeter());

            Console.ReadLine();
        }
    }
}
