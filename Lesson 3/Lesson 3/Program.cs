using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Program
    {
        //struct Complex
        //{
        //    public double im;
        //    public double re;

        //    public Complex Plus(Complex x)
        //    {
        //        Complex y;
        //        y.im = im + x.im;
        //        y.re = re + x.re;
        //        return y;
        //    }

        //    public Complex Minus(Complex x)
        //    {
        //        Complex y;
        //        y.im = im - x.im;
        //        y.re = re - x.re;
        //        return y;
        //    }

        //    public Complex Multi(Complex x)
        //    {
        //        Complex y;
        //        y.im = re * x.im + im * x.re;
        //        y.re = re * x.re - im * x.im;
        //        return y;
        //    }
        //    public string Tostring()
        //    {
        //        if (im<0) return re + (im + "i");
        //        else return re + "+" + im + "i";
        //    }
        //}

        //static void Main(string[] args)
        //{

        //    Complex complex1;
        //    complex1.re = 1;
        //    complex1.im = 1;

        //    Complex complex2;
        //    complex2.re = 2;
        //    complex2.im = 2;

        //    Complex result = complex1.Plus(complex2);
        //    Console.WriteLine(result.Tostring());
        //    result = complex1.Minus(complex2);
        //    Console.WriteLine(result.Tostring());
        //    result = complex1.Multi(complex2);
        //    Console.WriteLine(result.Tostring());
        //    Console.ReadKey();
        //}





        //class Complex
        //{
        //    private double im;
        //    double re;

        //    // Конструктор без параметров.
        //    public Complex()
        //    {
        //        im = 0;
        //        re = 0;
        //    }

        //    public Complex(double _im, double re)
        //    {
        //        im = _im;
        //        this.re = re;
        //    }
        //    public Complex Plus(Complex x2)
        //    {
        //        Complex x3 = new Complex();
        //        x3.im = x2.im + im;
        //        x3.re = x2.re + re;
        //        return x3;
        //    }
        //    public Complex Minus(Complex x2)
        //    {
        //        Complex x3 = new Complex();
        //        x3.im = x2.im - im;
        //        x3.re = x2.re - re;
        //        return x3;
        //    }
        //    public Complex Multi(Complex x2)
        //    {
        //        Complex x3 = new Complex();
        //        x3.im = re * x2.im + im * x2.re;
        //        x3.re = re * x2.re - im * x2.im;
        //        return x3;
        //    }
        //    public string Tostring()
        //    {
        //        return re + "+" + im + "i";
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Complex complex1 = new Complex(1, 1);
        //    Complex complex2 = new Complex(2, 2);
        //    Complex result = complex1.Plus(complex2);
        //    Console.WriteLine(result.Tostring());
        //    result = complex1.Minus(complex2);
        //    Console.WriteLine(result.Tostring());
        //    result = complex1.Multi(complex2);
        //    Console.WriteLine(result.Tostring());
        //    Console.ReadKey();
        //}



        

        static void Main(string[] args)
        {
            int n, sum = 0;
            do
            {
                bool X = Int32.TryParse(Console.ReadLine(), out n);
                if (X == false)
                {
                    Console.WriteLine("Ошибка при вводе данных");
                    n = 1;
                }
                else
                if (n % 2 != 0 && n > 0)
                {
                    sum = sum + n;
                }
            }
            while (n != 0);
            Console.WriteLine("Сумма нечетных чисел: {0}", sum);



            Console.ReadKey();
            
        }
    }
}
