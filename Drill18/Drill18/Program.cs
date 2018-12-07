using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill18
{
    class Program
    {
        static void Main(string[] args)
        {
            Emlpoyee emlpoyee = new Emlpoyee();
            emlpoyee.firstName = "Sample";
            emlpoyee.lastName = "Student";
            emlpoyee.SayName();
            IQuittable quit = new Emlpoyee();
            quit.Quit();
            Console.ReadLine();
        }
    }
}
