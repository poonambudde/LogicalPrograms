using System;

namespace Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Conversion");
            Console.WriteLine("Enter 1: Celsius to Fahrenheit    2: Fahrenheit to Celsius");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter temperature");
            int temp = Convert.ToInt32(Console.ReadLine());

            GetTemp(option, temp);
        }
        public static void GetTemp(int option, int temp)
        {

            switch (option)
            {
                case 1:
                    double celsius_To_Fahrenheit = (temp * 9 / 5) + 32;
                    Console.WriteLine($"{celsius_To_Fahrenheit} fahrenheit");
                    break;
                case 2:
                    double fahrenheit_To_Celsius = (temp - 32) * 5 / 9;
                    Console.WriteLine($"{fahrenheit_To_Celsius} celsius");
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
    }
}
