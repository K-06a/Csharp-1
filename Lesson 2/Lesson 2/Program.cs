using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static bool Check(string login, string passw)
        {
            return (login == "root" && passw == "GeekBrains");

        }

        static void Loop(int a, int b)
        {
            Console.Write("{0}  ", a);
            if (a < b) Loop(a + 1, b);
        }

        static void Main(string[] args)
        {
            //int a, b, c, min;
            //Console.Write("Первое число:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Второе число:");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Третье число:");
            //c = Convert.ToInt32(Console.ReadLine());
            //if (a < b && a < c)
            //{
            //    min = a;
            //}
            //else if (b < c)
            //{
            //    min = b;
            //}
            //else
            //{
            //    min = c;
            //}
            //Console.WriteLine("Меньшее из трех чисел {0}", min);



            //Console.WriteLine("Введите целое число");
            //int n = int.Parse(Console.ReadLine());
            //int count = 0;

            //while (n != 0)
            //{
            //    count++;
            //    n = n / 10;	
            //}
            //Console.WriteLine(count);



            //int n, sum = 0;
            //do
            //{
            //    n = Convert.ToInt32(Console.ReadLine());
            //    if (n % 2 != 0 && n > 0)
            //    {
            //        sum = sum + n;
            //    }
            //}
            //while (n != 0);
            //Console.WriteLine("Сумма нечетных чисел: {0}", sum);




            int count = 0;
            string login, passw;

            do
            {
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                passw = Console.ReadLine();
                count++;
                if (Check(login, passw) == false)
                    Console.WriteLine("Неверное сочетание логина и пароля!/n Попыток осталось: {0}", 3 - count);
            }
            while (count < 3 && Check(login, passw) == false);
            if (Check(login, passw) == false)
                Console.WriteLine("Исчерпано число попыток.");
            else Console.WriteLine("Добро пожаловать!");




            //Loop(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));






                                                                        
            Console.ReadLine();

        }
    }
}
