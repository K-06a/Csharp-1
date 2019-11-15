using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_6
{
    ////1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
    ////   Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).


    //public delegate double Fun(double x);
    //public delegate double Fun1(double x, double a);

    //class Program
    //{
    //    public static void Table(Fun F, double x, double b)
    //    {
    //        Console.WriteLine("----- X ----- Y -----");
    //        while (x <= b)
    //        {
    //            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
    //            x += 1;
    //        }
    //        Console.WriteLine("---------------------");
    //    }
    //    public static void Table(Fun1 F, double x, double b, double a)
    //    {
    //        Console.WriteLine($"При a = {a}");
    //        Console.WriteLine("----- X ----- Y -----");
    //        while (x <= b)
    //        {
    //            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
    //            x += 1;
    //        }
    //        Console.WriteLine("---------------------");
    //    }
    //    // Создаем метод для передачи его в качестве параметра в Table
    //    public static double MyFunc(double x)
    //    {
    //        return x * x * x;
    //    }

    //    public static double MyFuncA(double x, double a)
    //    {
    //        return a * x * x;
    //    }
    //    public static double MyFuncB(double x, double a)
    //    {
    //        return a * Math.Sin(x);
    //    }
    //    static void Main(string[] args)
    //    {
    //        // Создаем новый делегат и передаем ссылку на него в метод Table
    //        Console.WriteLine("Таблица функции MyFunc:");
    //        // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
    //        Table(new Fun(MyFunc), -2, 2);
    //        Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
    //        // Упрощение(c C# 2.0).Делегат создается автоматически.            
    //        Table(MyFunc, -2, 2);
    //        Console.WriteLine("Таблица функции Sin:");
    //        Table(Math.Sin, -2, 2);      // Можно передавать уже созданные методы
    //        Console.WriteLine("Таблица функции x^2:");
    //        // Упрощение(с C# 2.0). Использование анонимного метода
    //        Table(delegate (double x) { return x * x; }, 0, 3);

    //        Console.WriteLine("Таблица функции a*x^2:");
    //        Table(MyFuncA, -2, 2, 5);
    //        Console.WriteLine("Таблица функции a*sin(x):");
    //        Table(MyFuncB, -2, 2, 5);


    //        Console.ReadKey();

    //    }
    //}



    //Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
    //Использовать массив(или список) делегатов, в котором хранятся различные функции.

    public delegate double Fun(double x);
    class Program
    {
        
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        
        public static void SaveFunc(Fun Fundelegat, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(Fundelegat(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main(string[] args)
        {
            double start, end;
            Console.WriteLine("Введите значения начала и конца отрезка:");
            start = Convert.ToDouble(Console.ReadLine());
            end = Convert.ToDouble(Console.ReadLine());
            SaveFunc(F, "data.bin", start, end, 0.5);
            Console.WriteLine(Load("data.bin"));
            Console.ReadKey();
        }
    }





}
