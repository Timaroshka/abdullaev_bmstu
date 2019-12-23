using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;

namespace Lab3
{
    class Program
    {
        static int Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(9, 4);
            Square sq1 = new Square(5);
            Circle circ1 = new Circle(3);


            Console.WriteLine("\nArrayList");
            ArrayList array1 = new ArrayList();
            array1.Add(rect1);
            array1.Add(sq1);
            array1.Add(circ1);
            foreach (var x in array1)
                Console.WriteLine(x);

            List<Geometric_figures> array2 = new List<Geometric_figures>();
            array2.Add(rect1);
            array2.Add(sq1);
            array2.Add(circ1);
            Console.WriteLine("\nList");
            foreach (var i in array2)
                Console.WriteLine(i);

            array2.Sort();
            Console.WriteLine("\nList sorted");

            foreach (var i in array2)
                Console.WriteLine(i);

            Console.WriteLine("\nStack");
            SimpleStack<Geometric_figures> stack = new SimpleStack<Geometric_figures>();
            stack.Push(rect1);
            stack.Push(sq1);
            stack.Push(circ1);
            while (stack.Count > 0)
            {
                Geometric_figures f = stack.Pop();
                Console.WriteLine(f);
            }

            Console.WriteLine("\nMatrix");
            Matrix<Geometric_figures> matrix = new Matrix<Geometric_figures>(3, 3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0, 0] = rect1;
            matrix[1, 1, 1] = sq1;
            matrix[2, 2, 2] = circ1;
            Console.WriteLine(matrix.ToString());

            Console.ReadLine();
            return 0;






        }

    }
}
