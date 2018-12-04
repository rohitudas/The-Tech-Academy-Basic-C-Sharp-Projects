using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Course;
            string PageNum;
            string HelpBo;
            string Experiences;
            string Feedback;
            string Hours;

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?:");
            Course = Console.ReadLine();
            Console.WriteLine("What page number?:");
            PageNum = Console.ReadLine();
            Console.WriteLine("Do you need help with anything?(Answer \"true\"or \"false\"):");
            HelpBo = Console.ReadLine();
            Console.WriteLine("Were there any posative experiences you'd like to share? Please give specifics");
            Experiences = Console.ReadLine();
            Console.WriteLine("is there any feedback you'd like to provide? Please give specifics:");
            Feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study?:");
            Hours = Console.ReadLine();

            if (Convert.ToBoolean(HelpBo) == true)
                Console.WriteLine("Thank you for your answers. An instructor will Come to help shortly. Have a great Day!");
            else
                Console.WriteLine("Thank you for your answers. An intructor will respond to this shortly. Have a great Day!");
            Console.ReadLine();
     
        }
    }
}
