
using System;
using System.Diagnostics;
namespace Stopwatch_Program
{
    class program
    {
        static void Main(string[] args)
            {
            // Create new stopwatch.
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Press 1 to start stopwatch");
            string start = Console.ReadLine().ToUpper();
            if (start == "1")
            {
             // Begin timing.
             stopwatch.Start();

             Console.WriteLine("Press 2 to start stopwatch");
             string stop = Console.ReadLine().ToUpper();
            if (stop == "2")
            {
            // Stop timing.
            stopwatch.Stop();
            }
            }
            // Write hours, minutes and seconds.
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);

        }
    }
}
