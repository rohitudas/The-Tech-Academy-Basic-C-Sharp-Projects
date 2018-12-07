using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill27
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("GIMME YOUR AGE:");
                string age = Console.ReadLine();
                if (Convert.ToInt16(age) < 0) throw new NegException();
                var nowDate = DateTime.Today;
                int nowDateint = nowDate.Year;
                int BirthYear = nowDateint - Convert.ToInt16(age);
                Console.WriteLine("This is the year of your birth child:", BirthYear);

            }
            catch (NegException)
            {
                Console.WriteLine("You are not negative years old Benjamin Button");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("A critcal error has occured");
                Console.ReadLine();
            }

        }
    }
}
