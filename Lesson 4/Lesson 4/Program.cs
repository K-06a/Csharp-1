using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    //Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
    //Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
    class MyArray
    {
        int[] a;
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        public void Print()
        {
            foreach (int el in a)
                Console.WriteLine(el);
        }
        public void Check()
        {
            int count = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] % 3 == 0 ^ a[i + 1] % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество пар чисел: {0}", count);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(20, -10000, 10000);
            a.Print();
            a.Check();
            Console.ReadKey();
        }
    }



}