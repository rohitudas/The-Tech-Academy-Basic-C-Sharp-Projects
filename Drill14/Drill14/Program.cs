using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill14
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputS;
            int input;
            decimal Dinput;

            QuickMath maffs = new QuickMath();

            Console.Write("Input integer:");
            inputS = Console.ReadLine();
            input = Convert.ToInt32(inputS);
            input = maffs.method(input);
            Console.WriteLine(input);

            Console.Write("Input Decimal:");
            inputS = Console.ReadLine();
            Dinput = Convert.ToDecimal(inputS);
            Dinput = maffs.method(Dinput);
            Console.WriteLine(Dinput);

            Console.Write("Input string integer:");
            inputS = Console.ReadLine();
            inputS = maffs.method(inputS);
            Console.WriteLine(inputS);

            Console.ReadLine();


        }
    }
}
