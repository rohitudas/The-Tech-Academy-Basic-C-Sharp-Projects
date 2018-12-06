using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill23
{
    class Program
    {
        static void Main(string[] args)
        {
            Number obj = new Number();
            obj.Amount = 4.98m;
            Console.WriteLine(obj.Amount);
            Console.ReadLine();
        }
    }
}
