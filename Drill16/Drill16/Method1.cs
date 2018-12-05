using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill16
{
    class DivideBy2
    {
        public void Method(int num1)
        {
            num1 = num1 / 2;
            Console.WriteLine("Your number divided by 2 is: {0}", num1);
        }

        public void Method(decimal num1,out string num2)
        {
            num2 = "yes";
            num1 = num1 / 2;
            Console.WriteLine("Your number divided by 2 in a differnt method: {0}", num1);
        }
    }
}
