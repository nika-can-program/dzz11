using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzz11
{
    class Student : IPrint, ISred
    {
        public void Print()
        {
            Console.WriteLine($"\\Ученик\\ А какая была домашка?");
        }

        int[] marks = new int[5];


        public void Calculate()
        {
            int sum = 0;
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                marks[i] = rand.Next(2, 6);
                sum = sum += marks[i];
            }
            Console.WriteLine("Оценки: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine($"Среднее арифметическое: {sum / 5}");

        }

    }
}
