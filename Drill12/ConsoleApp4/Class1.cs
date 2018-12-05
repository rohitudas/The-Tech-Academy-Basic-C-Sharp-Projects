using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drill12;

namespace Drill12
{
    class Class1
    {
        static void Main()
        {
            string numberS;
            int number;

            QuickMaths GetNumber = new QuickMaths();
            Console.Write("Enter Integer to do some quick maffs:");
            numberS = Console.ReadLine();
            number = Convert.ToInt16(numberS);
            number = GetNumber.Addition(number);
            number = GetNumber.Mutlipy(number);
            number = GetNumber.Subtraction(number);

            Console.WriteLine(number);
            Console.ReadLine();

        }
    }
}
