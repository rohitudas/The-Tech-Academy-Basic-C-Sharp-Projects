using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Drill 3 shows use of basic operators

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal Multi;
            string MultiS;
            Decimal Add;
            string AddS;
            decimal Divide;
            string DivideS;
            double Large;
            string LargeS;
            decimal d7;
            string d7S;

            Console.Write("Multiply by 50:");
            MultiS = Console.ReadLine();
            Multi = Convert.ToDecimal(MultiS);
            Multi = Multi * 50;
            Console.WriteLine("Answer: " + Multi);
            Console.Write("(Press Enter to Continue)");
            Console.ReadLine();

            Console.Write("Add 25:");
            AddS = Console.ReadLine();
            Add = Convert.ToDecimal(AddS);
            Add = Add + 25;
            Console.WriteLine("Answer: " + Add);
            Console.Write("(Press Enter to Continue)");
            Console.ReadLine();

            Console.Write("Divide by 12.5:");
            DivideS = Console.ReadLine();
            Divide = Convert.ToDecimal(DivideS);
            Divide = Divide / (decimal)12.5;
            Console.WriteLine("Answer: " + Divide);
            Console.Write("(Press Enter to Continue)");
            Console.ReadLine();

            Console.WriteLine("Larger then 50?:");
            LargeS = Console.ReadLine();
            Large = Convert.ToDouble(AddS);
            if (Large > 50)
                Console.WriteLine("Number is Larger");
            else if (Large <= 50)
                Console.WriteLine("Number is not Larger");
            else
                Console.WriteLine("an error has occured");
            Console.Write("(Press Enter to Continue)");
            Console.ReadLine();

            Console.WriteLine("Divide by 7 show remainder:");
            d7S = Console.ReadLine();
            d7 = Convert.ToDecimal(d7S);
            d7 = d7 % 7;
            Console.WriteLine("Answer: " + d7);
            Console.Write("(Press Enter to Continue)");
            Console.ReadLine();
        }
    }
}
