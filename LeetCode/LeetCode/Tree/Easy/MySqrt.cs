using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
   public class SolutionMySqrt
    {
        public int Solution(int x)
        {
            // return (int)(Math.Sqrt(x));
            if (x<=1)
                return x;
            long i = x;
            while (i >x/i )
            {
                i = (i + x / i) > 0 ? (i + x / i) : -1 * (i + x / i);
                i /= 2;
            }
            return (int)i;
        }
    }
}
