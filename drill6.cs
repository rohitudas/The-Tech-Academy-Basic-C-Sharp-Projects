using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
            double weight;
            string weightS;
            double width;
            string widthS;
            double height;
            string heightS;
            double lenght;
            string lengthS;
            double quote;
            double check;

            Console.WriteLine("Welcome to Package Express. Please folow the intstructioins below.");
            Console.Write("Please enter the weight of your package in lbs:");
            weightS = Console.ReadLine();
            weight = Convert.ToDouble(weightS);
            if (weight <= 50)
            {
                Console.Write("Please enter package width:");
                widthS = Console.ReadLine();
                width = Convert.ToDouble(widthS);
                Console.Write("Please enter package height:");
                heightS = Console.ReadLine();
                height = Convert.ToDouble(heightS);
                Console.Write("Please enter package length:");
                lengthS = Console.ReadLine();
                lenght = Convert.ToDouble(lengthS);

                if ((width + height + lenght) <= 50)
                {
                    quote = ((width + height + lenght)* weight) / 100;
                    check = quote - Math.Truncate(quote);
                    if (check == 0)
                    {
                        Console.WriteLine("Your Shipment Quote is: $" + quote + ".00");
                    }
                    else
                    {
                        Console.WriteLine("Your Shipment Quote is: $" + quote);
                    }
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day");
                }

            }
            else
            {
                Console.WriteLine("Package too heavy to be shiped via Package express. Have a good day.");
            }

            Console.WriteLine("Thank You!");
            Console.ReadLine();
        }
    }
}
