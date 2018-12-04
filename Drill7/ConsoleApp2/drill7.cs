using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool trigger = true;
            string question;
            while (trigger == true)
            {
                Console.WriteLine("keep going? yes or no:");
                question = Console.ReadLine();
                if (question == "no")
                {
                    trigger = false;
                }

            }
            Console.WriteLine("Do Version");
            do
            {
                Console.WriteLine("keep going? yes or no:");
                question = Console.ReadLine();
                if (question == "no")
                {
                    trigger = true;
                }
            }
            while (trigger == false);
        }
    }
}
