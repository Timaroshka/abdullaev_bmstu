using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Lab6_1
{
    class Program
    {
        public delegate float roots(float p1, int p2);

        static roots discr = (float p1, int p2) =>
        {
            return p1 * p1 - 4 * p2;

        };
        static Func<float, int, float> discr1 = (float p1, int p2) =>
        {
            return p1 * p1 - 4 * p2;

        };
        static float Findroot(float p1, int p2)
        {
            return p1 / (2 * p2);
        }



        static void equation(int a, int b, int c, roots discr, roots root)
        {
            if (discr(b, a * c) > 0)
            {
                Console.WriteLine("Первый корень: " + root(-b + discr(b, a * c), a));
                Console.WriteLine("Второй корень: " + root(-b - discr(b, a * c), a));
            }
            else
                if (discr(b, a * c) == 0)
                Console.WriteLine("Первый корень : " + root(-b, a));

            else
                if (discr(b, a * c) < 0)
                Console.WriteLine("Нет корней");
        }

        static void equation1(int a, int b, int c, Func<float, int, float> discr, Func<float, int, float> root)
        {
            if (discr(b, a * c) > 0)
            {
                Console.WriteLine("Первый корень: " + root(-b + discr(b, a * c), a));
                Console.WriteLine("Второй корень: " + root(-b - discr(b, a * c), a));
            }
            else
                if (discr(b, a * c) == 0)
                Console.WriteLine("Первый корень: " + root(-b, a));

            else
                if (discr(b, a * c) < 0)
                Console.WriteLine("Нет корней");
        }

        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Введите коэффициенты А, B, C");
            Console.Write("A: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("B: ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("C: ");
            c = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Корни найдены при помощи делегатов and лямбда-выражения:");
            equation(a, b, c, discr, Findroot);

            Console.WriteLine();
            Console.WriteLine("Корни найдены при помощи Func:");
            equation1(a, b, c, discr1, Findroot);

            Console.WriteLine();
            Console.WriteLine("Нажмите, чтобы продолжить");
            Console.Read();
        }
    }
}
