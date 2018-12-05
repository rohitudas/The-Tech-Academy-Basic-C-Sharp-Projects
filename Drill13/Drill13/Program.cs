using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill13
{
    class Program
    {
        static void Main(string[] args)
        {
            Practice doit = new Practice();
            int number = doit.Method1(1, 2);
            Console.WriteLine(number);
            Console.ReadLine();

        }
    }
}
