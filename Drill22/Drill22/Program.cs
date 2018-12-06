using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill22
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Employees = new Employee();
            Employees.FirstName = new List<string>();
            Employees.LastName = new List<string>();
            Employees.ID = new List<int>();

            Employees.ID.Add(0);
            Employees.FirstName.Add("Bill");
            Employees.LastName.Add("man");

            Employees.ID.Add(1);
            Employees.FirstName.Add("bob");
            Employees.LastName.Add("manner");

            Employees.ID.Add(2);
            Employees.FirstName.Add("Betsy");
            Employees.LastName.Add("mans");

            Employees.ID.Add(3);
            Employees.FirstName.Add("Bruh");
            Employees.LastName.Add("man");

            Employees.ID.Add(4);
            Employees.FirstName.Add("Bro");
            Employees.LastName.Add("tho");

            Employees.ID.Add(5);
            Employees.FirstName.Add("Joe");
            Employees.LastName.Add("Shmo");

            Employees.ID.Add(6);
            Employees.FirstName.Add("Joe");
            Employees.LastName.Add("Flo");

            Employees.ID.Add(7);
            Employees.FirstName.Add("Joe");
            Employees.LastName.Add("ey");

            Employees.ID.Add(8);
            Employees.FirstName.Add("JOEY");
            Employees.LastName.Add("WHEELER");

            Employees.ID.Add(9);
            Employees.FirstName.Add("Help");
            Employees.LastName.Add("Me");

            List<string> JoeList = new List<string>();
            int indexCount = 0;

            foreach(string employee in Employees.FirstName)
            {

                if (employee == "Joe")
                {
                    JoeList.Add(employee + " " + Employees.LastName[indexCount]);
                }
                indexCount++;
            }

            foreach(string ex in JoeList)
            {
                Console.WriteLine(ex);
            }


            List<string> JoeList2 = new List<string>();
            int count;
            JoeList2 = Employees.FirstName.Where(x => x == "Joe").ToList();
            Console.WriteLine("");
            Console.WriteLine("Same thing but Lambda:");
            foreach (string ex in JoeList2)
            {
                Console.WriteLine(ex);
            }

            List<int> lst = new List<int>();
            List<string> list1 = new List<string>();
            lst = Employees.ID.Where(x => x > 5).ToList();
            foreach(int id in lst)
            {
                list1.Add(Employees.FirstName[id] + " " + Employees.LastName[id]);
            }

            Console.WriteLine();
            Console.WriteLine("Greater then ID 5:");
            foreach (string ex in list1)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}
