using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.Write("Enter:");
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime dateTime = new DateTime();
            DateTime NewDateTime = new DateTime();
            dateTime = DateTime.Now;
            NewDateTime = dateTime.AddHours(hours);
            Console.WriteLine(NewDateTime);
            Console.ReadLine();
        }
    }
}
