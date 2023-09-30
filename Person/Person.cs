using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    class Person
    {
        private string name;
        private int age;
        private string address;

        // Метод для установки имени
        public void SetName(string name)
        {
            this.name = name;
        }

        // Метод для получения имени
        public string GetName()
        {
            return name;
        }

        // Метод для установки возраста
        public void SetAge(int age)
        {
            this.age = age;
        }

        // Метод для получения возраста
        public int GetAge()
        {
            return age;
        }

        // Метод для установки адреса
        public void SetAddress(string address)
        {
            this.address = address;
        }

        // Метод для получения адреса
        public string GetAddress()
        {
            return address;
        }
    }

    class GetInfo
    {
        static void Main()
        {
            // Создаем объекты класса Person
            Person person1 = new Person();
            Person person2 = new Person();

            // Вводим данные для первого объекта
            Console.Write("Введите имя для первой персоны: ");
            string name1 = Console.ReadLine();
            person1.SetName(name1);

            Console.Write("Введите возраст для первой персоны: ");
            int age1 = int.Parse(Console.ReadLine());
            person1.SetAge(age1);

            Console.Write("Введите адрес для первой персоны: ");
            string address1 = Console.ReadLine();
            person1.SetAddress(address1);

            // Вводим данные для второго объекта
            Console.Write("Введите имя для второй персоны: ");
            string name2 = Console.ReadLine();
            person2.SetName(name2);

            Console.Write("Введите возраст для второй персоны: ");
            int age2 = int.Parse(Console.ReadLine());
            person2.SetAge(age2);

            Console.Write("Введите адрес для второй персоны: ");
            string address2 = Console.ReadLine();
            person2.SetAddress(address2);

            // Выводим информацию о каждом объекте
            Console.WriteLine("Имя: " + person1.GetName());
            Console.WriteLine("Возраст: " + person1.GetAge());
            Console.WriteLine("Адрес: " + person1.GetAddress());

            Console.WriteLine();

            Console.WriteLine("Имя: " + person2.GetName());
            Console.WriteLine("Возраст: " + person2.GetAge());
            Console.WriteLine("Адрес: " + person2.GetAddress());

            Console.ReadLine();
        }
    }
}