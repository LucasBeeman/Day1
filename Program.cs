using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            Console.Write("How many hours of sleep did you get last night?: ");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if(hoursOfSleep > 24)
            {
                Console.WriteLine("That's impossible");
            }
            else if(hoursOfSleep >= 8 && hoursOfSleep < 24)
            {
                Console.WriteLine("Thats a good amount of sleep");
            }
            else if(hoursOfSleep >= 6 && hoursOfSleep < 24)
            {
                Console.WriteLine("Not bad, but get more sleep");
            }
            else if(hoursOfSleep < 6 && hoursOfSleep < 24)
            {
                Console.WriteLine("Get some more sleep, bozo");
            }
            else
            {
                Console.WriteLine("IDK what you said");
            }

            Console.Write("Enter any key to exit: ");
            Console.ReadKey();

        }
    }
}
