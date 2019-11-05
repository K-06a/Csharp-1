using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {

        static double Result(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            //Console.Write("Укажите имя:");
            //var name = Console.ReadLine();
            //Console.Write("Укажите фамилию:");
            //var Sname = Console.ReadLine();
            //Console.Write("Укажите возраст:");
            //var age = Console.ReadLine();
            //Console.Write("Укажите рост(см):");
            //var H = Console.ReadLine();
            //Console.Write("Укажите вес(кг):");
            //var W = Console.ReadLine();
            //Console.WriteLine("a) "+ name + " " + Sname + ", " + age + "лет, " + H + "см, " + W + "кг.");
            //Console.WriteLine("б) {0} {1}, {2}лет, {3}см, {4}кг.", name, Sname, age, H, W);
            //Console.WriteLine($"в) {name} {Sname}, {age}лет, {H}см, {W}кг.");



            //Console.Write("Укажите рост(м):");            
            //double h = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Укажите вес(кг):");
            //double m = Convert.ToDouble(Console.ReadLine());
            //double i = m / (h * h);
            //Console.WriteLine("ИМТ=" + i);



            //3a)

            //int x1 = 12;
            //int x2 = 8;
            //int y1 = 5;
            //int y2 = 9;
            //var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Console.WriteLine("{0:F2}", r);

            //3б)

            //int x1 = 12;
            //int x2 = 8;
            //int y1 = 5;
            //int y2 = 9;
            //Console.WriteLine("{0:F2}", Result(x1,x2,y1,y2));



            //int a = 3;
            //int b = 4;
            //int t = a;
            //a = b;
            //b = t;



            Console.WriteLine("Кабанов Сергей, СПб");
            

            Console.ReadKey();
        }
    }
}
