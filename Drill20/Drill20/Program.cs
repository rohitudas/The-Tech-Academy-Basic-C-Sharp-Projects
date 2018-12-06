using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill20
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> test1 = new Employee<string>();
            Employee<int> test2 = new Employee<int>();
            test1.things = new List<string>();
            test2.things = new List<int>();

            test1.things.Add("A");
            test1.things.Add("B");
            test1.things.Add("C");
            test1.things.Add("D");
            test1.things.Add("E");

            test2.things.Add(1);
            test2.things.Add(2);
            test2.things.Add(3);
            test2.things.Add(4);
            test2.things.Add(5);

            for (int i = 0; i < test1.things.Count; i++)
            {
                Console.WriteLine(test1.things[i]);
            }
            for (int i = 0; i < test2.things.Count; i++)
            {
                Console.WriteLine(test2.things[i]);
            }

            Console.ReadLine();
        }
    }
}
