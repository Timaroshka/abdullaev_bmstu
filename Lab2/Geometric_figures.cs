using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public abstract class Geometric_figures : IComparable
    {
        public abstract double finding_area();
        public int CompareTo(object obj)
        {
            Geometric_figures p = (Geometric_figures)obj;
            if (this.finding_area() < p.finding_area()) return -1;
            else if (this.finding_area() == p.finding_area()) return 0;
            else return 1;
        }
    }
}