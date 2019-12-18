using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Program
    {

        static int Main(string[] args)
        {
            Rectangle Rect1 = new Rectangle(4, 8);
            Square Square1 = new Square(6);
            Circle Circ1 = new Circle(9);
            Rect1.Print();
            Square1.Print();
            Circ1.Print();
            Console.ReadLine();
            return 0;
        }
    }
}
