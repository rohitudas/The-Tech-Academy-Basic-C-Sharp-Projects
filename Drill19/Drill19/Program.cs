using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill19
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee();
            Employee person2 = new Employee();
            bool check;

            person1.Id = 1;
            person2.Id = 2;
            check = person1 == person2;

            Console.WriteLine(check);
            Console.ReadLine();
        }
    }
}
