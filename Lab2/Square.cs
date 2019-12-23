using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public class Square : Rectangle, IPrint
    {
        public Square(double yourlength)
        {
            _length1 = _length2 = yourlength;
            finding_area();
        }
        public override string ToString()
        {
            return "Length of the side: " + _length1.ToString() + "; Square: " + finding_area().ToString() + ";";
        }
    }
}
