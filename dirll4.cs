using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            double HourlyRate1;
            string HourlyRate1S;
            int HoursWorked1;
            string HoursWorked1S;

            double HourlyRate2;
            string HourlyRate2S;
            int HoursWorked2;
            string HoursWorked2S;

            double person1;
            double person2;

            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate:");
            HourlyRate1S = Console.ReadLine();
            HourlyRate1 = Convert.ToDouble(HourlyRate1S);
            Console.Write("Hours worked per week:");
            HoursWorked1S = Console.ReadLine();
            HoursWorked1 = Convert.ToInt16(HoursWorked1S);
  
            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate:");
            HourlyRate2S = Console.ReadLine();
            HourlyRate2 = Convert.ToDouble(HourlyRate2S);
            Console.Write("Hours worked per week:");
            HoursWorked2S = Console.ReadLine();
            HoursWorked2 = Convert.ToInt16(HoursWorked2S);
            person1 = (HourlyRate1 * HoursWorked1) * 52;
            person2 = (HourlyRate2 * HoursWorked2) * 52;

            Console.WriteLine("Annual salary of Person 1: " + person1);
            Console.WriteLine("Annual salary of Person 2: " + person2);
            Console.WriteLine();
            if (person1 > person2)
            {
                Console.WriteLine("Does Person 1 make more money then Person 2: True");
            }
            else if (person1 == person2)
            {
                Console.WriteLine("Does Person 1 make more money then Person 2?: False");
                Console.WriteLine("They make the same amount");
            }
            else
            {
                Console.WriteLine("Does Person 1 make more money then Person 2: False");
            }
            Console.ReadLine();
        }
    }
}
