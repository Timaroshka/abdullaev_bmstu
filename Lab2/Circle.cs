using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public class Circle : Geometric_figures, IPrint
    {
        private double _radius;
        private double area;
        public Circle(double yourradius)
        {
            _radius = yourradius;
            finding_area();
        }

        public double radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public override double finding_area()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }

        public override string ToString()
        {
            return "Radius of the circle  " + _radius.ToString() + "; Square: " + finding_area().ToString() + ";";
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
