using System;

namespace Day_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int d0, m0, y0, x;
            Console.WriteLine("Enter Date from 1 to 31: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month from 1 to 12: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (d > 0 && m > 0 && y > 0 && d <= 31 && m <= 12)
            {
                y0 = y - (14 - m) / 12;
                x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                m0 = m + 12 * ((14 - m) / 12) - 2;
                d0 = (d + x + 31 * m0 / 12) % 7;

                Console.WriteLine("Day of week is: " + d0);
                switch (d0)
                {
                    case 0:
                        Console.WriteLine("Sunday");
                        break;
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednsday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Please Enter Correct Date");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please Enter Correct Date");
            }
        }
    }
}


//using System;

//namespace Day_Of_Week
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a date");
//            Console.WriteLine("Enter a day from 1 to 31");
//            int d = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter a month from 1 to 12");
//            int m = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter a year");
//            int y = Convert.ToInt32(Console.ReadLine());
//            DayOfWeek(d, m, y);
//        }
//        public static void DayOfWeek(int d, int m, int y)
//        {
//            int y1 = y - (14 - m) / 12;
//            int x = y1 + y1 / 4 - y1 / 100 + y1 / 400;
//            int m1 = m + 12 * ((14 - m) / 12) - 2;
//            int d1 = (d + x + 31 * m1 / 12) % 7;

//            switch (d1)
//            {
//                case 0:
//                    Console.WriteLine("sunday");
//                    break;
//                case 1:
//                    Console.WriteLine("monday");
//                    break;
//                case 2:
//                    Console.WriteLine("tuesday");
//                    break;
//                case 3:
//                    Console.WriteLine("wednesday");
//                    break;
//                case 4:
//                    Console.WriteLine("thursday");
//                    break;
//                case 5:
//                    Console.WriteLine("friday");
//                    break;
//                case 6:
//                    Console.WriteLine("saturday");
//                    break;
//            }
//        }
//    }
//}
