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
            double[] Ar = new double[4] { 5, 4, 3, 12 };
            string input;

            Console.Write("Input number to divide by:");
            input = Console.ReadLine();
            try
            {
                for (int i = 0; i < Ar.Length; i++)
                {
                    Console.WriteLine(Ar[i] / Convert.ToInt16(input));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input please enter a number.");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Please do not attempt divide by zero");
            }
            catch(Exception)
            {
                Console.WriteLine("An error has occured");
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
