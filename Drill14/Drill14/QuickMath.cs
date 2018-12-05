using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill14
{
    class QuickMath
    {
        public int method(int num1)
        {
            num1 = num1 * 2;
            return num1;
        }
        public decimal method(decimal num1)
        {
            num1 = num1 / 3;
            return num1;
        }
        public string method(string num1)
        {
            int x;
            string y = "";

            try
            {
                x = Convert.ToInt16(num1);
                x = x * 10;
                y = Convert.ToString(x);
            }
            catch
            {
                Console.WriteLine("That is not an integer");
            }
            return y;
        }
           
    }
}
