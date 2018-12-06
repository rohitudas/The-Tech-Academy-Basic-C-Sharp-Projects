using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill19
{
    class Employee
    {
        public int Id { get; set; }
        public static bool operator== (Employee employee1, Employee employee2)
        {
            bool check;
            if (employee1.Id == employee2.Id)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool check;
            if (employee1.Id != employee2.Id)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
    }
}
