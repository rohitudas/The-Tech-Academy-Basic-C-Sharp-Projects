using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill26
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Geoff = new Employee();
            Geoff.Name = "Geoff";
            const string CreatorName = "Rohit";
            Console.WriteLine("Made by {0}", CreatorName);
            Console.WriteLine(Geoff.Name);
            Console.ReadLine();


        }
    }
}
