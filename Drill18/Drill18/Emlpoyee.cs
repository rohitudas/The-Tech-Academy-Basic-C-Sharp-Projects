﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill18
{
    class Emlpoyee:Person, IQuittable
    {
        public int ID { get; set; }

        public void Quit()
        {
            Console.WriteLine("quitting...");
        }

        IQuittable Person = new Emlpoyee();
    }
}
