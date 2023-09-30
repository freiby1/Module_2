using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Car(string brand, string model, int year, double price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }

        public double CalculatePriceWithDiscount(double discountPercentage)
        {
            double discount = (discountPercentage / 100) * Price;
            double priceWithDiscount = Price - discount;
            return priceWithDiscount;
        }

        public double CalculatePriceWithNDS(double ndsRate)
        {
            double tax = (ndsRate / 100) * Price;
            double priceWithNDS = Price + tax;
            return priceWithNDS;
        }
    }

    class CarInfo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные об автомобиле:");
            Console.Write("Марка: ");
            string brand = Console.ReadLine();

            Console.Write("Модель: ");
            string model = Console.ReadLine();

            Console.Write("Год выпуска: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Цена: ");
            double price = double.Parse(Console.ReadLine());

            Car car = new Car(brand, model, year, price);

            Console.Write("Введите процент скидки: ");
            double discountPercentage = double.Parse(Console.ReadLine());

            double priceWithDiscount = car.CalculatePriceWithDiscount(discountPercentage);
            Console.WriteLine($"Стоимость с учетом скидки: {priceWithDiscount}");

            Console.Write("Введите ставку НДС (%): ");
            double ndsRate = double.Parse(Console.ReadLine());

            double priceWithNDS = car.CalculatePriceWithNDS(ndsRate);
            Console.WriteLine($"Стоимость с учетом НДС: {priceWithNDS}");

            Console.ReadLine();
        }
    }
}
