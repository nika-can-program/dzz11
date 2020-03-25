using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzz11
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Print();

            Teacher teacher = new Teacher();
            teacher.Print();

            Student student = new Student();
            student.Print();
            student.Calculate();

            Console.ReadLine();
        }
    }
}
