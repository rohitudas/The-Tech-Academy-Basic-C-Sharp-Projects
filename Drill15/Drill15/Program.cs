using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill15
{
    class Program
    {
        static void Main(string[] args)
        {
            Quickmaths domath = new Quickmaths();
            int num1;
            int num2;
            string inputS = "";

            Console.WriteLine("Enter integers");
            Console.Write("Integer 1:");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Integer 2(Optinal):");
            // Multiplies by 2 if no input
            inputS = Console.ReadLine();
            if (inputS != "")
            {
               num2 = Convert.ToInt16(inputS);
               Console.WriteLine(domath.method1(num1, num2));
            }
            else
            {
                Console.WriteLine(domath.method1(num1));
            }
            
            Console.ReadLine();

        }
    }
}
