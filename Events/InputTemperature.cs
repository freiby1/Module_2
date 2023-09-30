using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    // Создаем класс TemperatureSensor
    class TemperatureSensor
    {
        // Объявляем событие TemperatureChanged
        public event EventHandler<double> TemperatureChanged;

        private double currentTemperature;

        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set
            {
                if (currentTemperature != value)
                {
                    currentTemperature = value;
                    OnTemperatureChanged(currentTemperature);
                }
            }
        }

        protected virtual void OnTemperatureChanged(double newTemperature)
        {
            TemperatureChanged?.Invoke(this, newTemperature);
        }
    }

    // Создаем класс Thermostat
    class Thermostat
    {
        public void SubscribeToTemperatureSensor(TemperatureSensor sensor)
        {
            // Подписываемся на событие TemperatureChanged
            sensor.TemperatureChanged += HandleTemperatureChange;
        }

        public void UnsubscribeFromTemperatureSensor(TemperatureSensor sensor)
        {
            // Отписываемся от события TemperatureChanged
            sensor.TemperatureChanged -= HandleTemperatureChange;
        }

        private void HandleTemperatureChange(object sender, double newTemperature)
        {
            // Реагируем на изменение температуры
            if (newTemperature < 20)
            {
                Console.WriteLine("Отопление включено.");
            }

            else
            {
                Console.WriteLine("Отопление выключено.");
            }
        }
    }

    class Events
    {
        static void Main()
        {
            TemperatureSensor sensor = new TemperatureSensor();
            Thermostat thermostat = new Thermostat();

            // Подписываемся на событие TemperatureChanged
            thermostat.SubscribeToTemperatureSensor(sensor);

            while (true)
            {
                Console.Write("Введите текущую температуру: ");
                if (double.TryParse(Console.ReadLine(), out double temperature))
                {
                    // Изменяем температуру при успешном вводе
                    sensor.CurrentTemperature = temperature;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                }
            }
        }
    }
}