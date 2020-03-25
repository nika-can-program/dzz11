using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzz11
{
    class Teacher : IPrint
    {
        public void Print()
        {
            Console.WriteLine($"\\Учитель\\ Достаем двойные листочки.");
        }
    }
}
