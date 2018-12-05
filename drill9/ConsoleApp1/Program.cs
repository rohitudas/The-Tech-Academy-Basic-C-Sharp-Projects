using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringAr = new string[6];
            int[] intAr = new int[6];
            List<string> stringList = new List<string>();
            string StringIndexAr;
            string IntIndexAr;
            string ListIndex;

            stringAr[0] = "zero";
            stringAr[1] = "one";
            stringAr[2] = "two";
            stringAr[3] = "three";
            stringAr[4] = "four";
            stringAr[5] = "five";
            intAr[0] = 0;
            intAr[1] = 11;
            intAr[2] = 22;
            intAr[3] = 33;
            intAr[4] = 44;
            intAr[5] = 55;
            stringList.Add("ZERO");
            stringList.Add("ONE");
            stringList.Add("TWO");
            stringList.Add("THREE");
            stringList.Add("FOUR");
            stringList.Add("FIVE");

            try
            {
                Console.Write("String array, pick an Index from 0 to 5:");
                StringIndexAr = Console.ReadLine();
                Console.WriteLine(stringAr[Convert.ToInt16(StringIndexAr)]);
                Console.Write("<Press enter to continue>");
                Console.ReadLine();

                Console.Write("int array, pick an Index from 0 to 5:");
                IntIndexAr = Console.ReadLine();
                Console.WriteLine(intAr[Convert.ToInt16(IntIndexAr)]);
                Console.Write("<Press enter to continue>");
                Console.ReadLine();

                Console.Write("List, pick an Index from 0 to 5:");
                ListIndex = Console.ReadLine();
                Console.WriteLine(stringList[Convert.ToInt16(ListIndex)]);
                Console.Write("<Press enter to continue>");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("An error has occured input invalid.");
                Console.Write("<Press enter to close>");
                Console.ReadLine();
            }
        }
    }
}
