using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string AgeS;
            int Age;
            string DUIS;
            bool DUI;
            string ticketS;
            int ticket;

            Console.Write("What is your age?:");
            AgeS = Console.ReadLine();
            Age = Convert.ToInt16(AgeS);
            Console.Write("Have you ever had a DUI? true or false:");
            DUIS = Console.ReadLine();
            DUI = Convert.ToBoolean(DUIS);
            Console.Write("How many speeding tickets have you had?:");
            ticketS = Console.ReadLine();
            ticket = Convert.ToInt16(ticketS);
            Console.WriteLine("Qualified?");
            if ((ticket < 3) && (DUI == false) && (Age > 15))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();

        }
    }
}
