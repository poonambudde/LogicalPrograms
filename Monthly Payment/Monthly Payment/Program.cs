using System;

namespace MonthlyPayment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculate monthly payment");
            Console.WriteLine("Enter the value of principal amount: ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the year: ");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter percent interest");
            double R = Convert.ToDouble(Console.ReadLine());
            GetMonthlyPayment(P, Y, R);
        }

        public static void GetMonthlyPayment(double P, double Y, double R)
        {
           
            double n = 12 * Y;
            double r = R / (12 * 100);
            double payment = P * r / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine(payment +  " is monthly payment");
        }
    }
}

