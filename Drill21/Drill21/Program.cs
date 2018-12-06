using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill21
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter A day of th week");
                string input = Console.ReadLine();
                Days Day = (Days)Enum.Parse(typeof(Days), input);
                Console.WriteLine(Day + " is a day. wow.");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please Enter an actual day of th week.pleb.");
                Console.ReadLine();
            }

        }
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thrusday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
