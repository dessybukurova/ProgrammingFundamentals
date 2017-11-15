using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceForWingFlaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            var distance = (wingFlaps / 1000) * distanceForWingFlaps;
            var seconds = (wingFlaps / endurance) * 5;

            seconds += wingFlaps / 100;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{seconds} s.");


        }
    }
}
