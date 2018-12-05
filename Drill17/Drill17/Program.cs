using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill17
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee();
            sample.FirstName = "Sample";
            sample.LastName = "Student";
            sample.SayName();
            Console.ReadLine();

        }
    }
}
