using System;

namespace Square_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Square Root using Newtons Method");
            Console.WriteLine("Enter Non negative Number :-");
            double c = Convert.ToDouble(Console.ReadLine());
            GetRoot(c);
        }
        public static void GetRoot(double c)
        {
            double t = c;
            while ((Math.Abs(t - c / t)) > (1e-15 * t))
            {
                t = (t + (c / t)) / 2;
            }
            Console.WriteLine(t);
        }
    }
}
