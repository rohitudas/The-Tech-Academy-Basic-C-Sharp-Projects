using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill20
{
    class Employee<T>
    {
        public List<T> things { get; set; }
    }
}
