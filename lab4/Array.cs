using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Array
    {
        public static List<Extr> DivideSubArrays(int beginIndex, int endIndex, int subArraysCount)
        {
            List<Extr> result = new List<Extr>();

            if ((endIndex - beginIndex) <= subArraysCount)
            {
                result.Add(new Extr(0, (endIndex - beginIndex)));
            }
            else
            {
                int delta = (endIndex - beginIndex) / subArraysCount;
                int currentBegin = beginIndex;

                while ((endIndex - currentBegin) >= 2 * delta)
                {
                    result.Add(new Extr(currentBegin, currentBegin + delta));
                    currentBegin += delta;
                }
                result.Add(new Extr(currentBegin, endIndex));
            }
            return result;
        }
    }
}