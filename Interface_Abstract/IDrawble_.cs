using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Abstract
{
    // Создаем интерфейс IDrawable с методом Draw()
    interface IDrawable
    {
        void Draw();
    }

    // Создаем класс Circle, реализующий интерфейс IDrawable
    class Circle : IDrawable
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Рисуем круг с радиусом {radius}");
        }
    }

    // Создаем класс Rectangle, реализующий интерфейс IDrawable
    class Rectangle : IDrawable
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Рисуем прямоугольник с шириной {width} и высотой {height}");
        }
    }

    // Создаем класс Triangle, реализующий интерфейс IDrawable
    class Triangle : IDrawable
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public void Draw()
        {
            Console.WriteLine($"Рисуем треугольник со сторонами {side1}, {side2}, {side3}");
            Console.ReadLine();
        }
    }

    class IDrawable_
    {
        static void Main()
        {
            // Создаем массив объектов, реализующих интерфейс IDrawable
            IDrawable[] drawableObjects = new IDrawable[]
            {
            new Circle(5.0),
            new Rectangle(3.0, 4.0),
            new Triangle(3.0, 4.0, 5.0)
            };

            // Вызываем метод Draw() для каждого объекта
            foreach (var drawableObject in drawableObjects)
            {
                drawableObject.Draw();
            }
        }
    }
}
