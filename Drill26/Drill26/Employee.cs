﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill26
{
    public class Employee
    {
     
        public Employee(string name = "", int id = 0)
        {
            Name = name;
            ID = id;
        }
        
        
        public string Name { get; set; }
        public int ID { get; set; }

    }
}
