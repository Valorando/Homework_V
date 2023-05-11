/*Создайте пространство имен "TemperatureConversion", в котором определите статический класс "TemperatureConverter" для конвертации температуры между шкалами Цельсия, Фаренгейта и Кельвина.

В классе "TemperatureConverter" определите следующие статические методы:

CelsiusToFahrenheit - метод, принимающий значение температуры в градусах Цельсия и возвращающий его эквивалент в градусах Фаренгейта

FahrenheitToCelsius" - метод, принимающий значение температуры в градусах Фаренгейта и возвращающий его эквивалент в градусах Цельсия

CelsiusToKelvin" - метод, принимающий значение температуры в градусах Цельсия и возвращающий его эквивалент в Кельвинах

"KelvinToCelsius" - метод, принимающий значение температуры в Кельвинах и возвращающий его эквивалент в градусах Цельсия

"FahrenheitToKelvin" - метод, принимающий значение температуры в градусах Фаренгейта и возвращающий его эквивалент в Кельвинах

"KelvinToFahrenheit" - метод, принимающий значение температуры в Кельвинах и возвращающий его эквивалент в градусах Фаренгейта*/


using TemperatureConversion;

namespace TemperatureConversion
{
   static class TemperatureConverter
    {
        public static void CelsiusToFahrenheit()
        {
            double value;
            double result;
            Console.Write("\t\t\tВведите значение температуры в Цельсиях: ");
            value = Convert.ToInt32(Console.ReadLine());
            result = value * 1.8 + 32;
            Console.WriteLine($"\t\t\t{value} градусов Цельсия это {result} градусов Фаренгейта.");
        }

        public static void FahrenheitToCelsius()
        {
            double value;
            double result;
            Console.Write("\t\t\tВведите значение температуры в Фаренгейтах: ");
            value = Convert.ToInt32(Console.ReadLine());
            result = (value - 32) / 1.8;
            Console.WriteLine($"\t\t\t{value} градусов Фаренгейта это {result} градусов Цельсия.");
        }

        public static void CelsiusToKelvin()
        {
            double value;
            double result;
            Console.Write("\t\t\tВведите значение температуры в Цельсиях: ");
            value = Convert.ToInt32(Console.ReadLine());
            result = value + 273.15;
            Console.WriteLine($"\t\t\t{value} градусов Цельсия это {result} Кельвинов.");
        }

        public static void KelvinToCelsius()
        {
            double value;
            double result;
            Console.Write("\t\t\tВведите значение температуры в Кельвинах: ");
            value = Convert.ToInt32(Console.ReadLine());
            result = value - 273.15;
            Console.WriteLine($"\t\t\t{value} Кельвинов это {result} градусов Цельсия.");
        }

        public static void FahrenheitToKelvin()
        {
            double value;
            double result;
            Console.Write("\t\t\tВведите значение температуры в Фаренгейтах: ");
            value = Convert.ToInt32(Console.ReadLine());
            result = (value - 32) * 5 / 9 + 273.15;
            Console.WriteLine($"\t\t\t{value} градусов Фаренгейта это {result} Кельвинов.");
        }

        public static void KelvinToFahrenheit()
        {
            double value;
            double result;
            Console.Write("\t\t\tВведите значение температуры в Кельвинах: ");
            value = Convert.ToInt32(Console.ReadLine());
            result = (value - 273.15) * 9 / 5 + 32;
            Console.WriteLine($"\t\t\t{value} Кельвинов это {result} градусов Фаренгейта.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    { 
        int key;
        Console.WriteLine("\t\t\t   |Конвертер температур|");
        do
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\t|Выберите единицу измерения|");
            Console.WriteLine("\t\t\t|        Цельсий -> 1      |");
            Console.WriteLine("\t\t\t|        Фаренгейт -> 2    |");
            Console.WriteLine("\t\t\t|        Кельвин -> 3      |");
            Console.WriteLine("\t\t\t|        Выход -> 4        |");
            Console.WriteLine();

            while (!int.TryParse(Console.ReadLine(), out key))
            {
                Console.WriteLine();
                Console.WriteLine("\t\t\t|Выберите единицу измерения|");
                Console.WriteLine("\t\t\t|        Цельсий -> 1      |");
                Console.WriteLine("\t\t\t|        Фаренгейт -> 2    |");
                Console.WriteLine("\t\t\t|        Кельвин -> 3      |");
                Console.WriteLine("\t\t\t|        Выход -> 4        |");
                Console.WriteLine();
            }
                

            if (key == 1)
            {
                Console.WriteLine("\t\t\t|Во что нужно перевести?|");
                Console.WriteLine("\t\t\t|     Фаренгейт -> 1    |");
                Console.WriteLine("\t\t\t|     Кельвин -> 2      |");
                int key_two;
                key_two = Convert.ToInt32(Console.ReadLine());

                if (key_two == 1)
                {
                    TemperatureConverter.CelsiusToFahrenheit();
                }

                if (key_two == 2)
                {
                    TemperatureConverter.CelsiusToKelvin();
                }
            }

            if (key == 2)
            {
                Console.WriteLine("\t\t\t|Во что нужно перевести?|");
                Console.WriteLine("\t\t\t|     Цельсий -> 1      |");
                Console.WriteLine("\t\t\t|     Кельвин -> 2      |");
                int key_three;
                key_three = Convert.ToInt32(Console.ReadLine());

                if (key_three == 1)
                {
                    TemperatureConverter.FahrenheitToCelsius();
                }

                if (key_three == 2)
                {
                    TemperatureConverter.FahrenheitToKelvin();
                }
            }

            if (key == 3)
            {
                Console.WriteLine("\t\t\t|Во что нужно перевести?|");
                Console.WriteLine("\t\t\t|     Цельсий -> 1      |");
                Console.WriteLine("\t\t\t|     Фаренгейт -> 2    |");
                int key_four;
                key_four = Convert.ToInt32(Console.ReadLine());

                if (key_four == 1)
                {
                    TemperatureConverter.KelvinToCelsius();
                }

                if (key_four == 2)
                {
                    TemperatureConverter.KelvinToFahrenheit();
                }
            }

            if (key == 4)
            {
                Environment.Exit(4);
            }

        } while (true);
    }

    

}