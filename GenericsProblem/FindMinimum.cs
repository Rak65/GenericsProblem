using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class FindMinimum
    {
        public static T FindMin<T>(T a, T b, T c) where T : IComparable<T>
        {
            T min = a;

            if (b.CompareTo(min) < 0)
                min = b;

            if (c.CompareTo(min) < 0)
                min = c;

            return min;
        }
    }
}
