using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Drill23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\rohit\OneDrive\Desktop\testLog\log.txt",text);
            text = File.ReadAllText(@"C:\Users\rohit\OneDrive\Desktop\testLog\log.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
