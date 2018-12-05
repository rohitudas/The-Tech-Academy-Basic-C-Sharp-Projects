using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill16
{
    static class Program
    {
        static void Main(string[] args)
        {
            DivideBy2 maffs = new DivideBy2();
            string divby = "no";

            string inputS;
            Console.Write("Enter integer:");
            inputS = Console.ReadLine();
            maffs.Method(Convert.ToInt16(inputS));
            maffs.Method(Convert.ToDecimal(inputS), out divby);
            Console.WriteLine("Out paramter {0}", divby);
            Console.ReadLine();
        }
    }
}
