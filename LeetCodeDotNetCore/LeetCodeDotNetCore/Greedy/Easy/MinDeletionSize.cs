using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy.Easy
{

   public class MinDeletionSize
    {
        public int Solution (string[] A)
        {
            var array = new char[A.Length][];
            var res = 0;
            for (var i = 0; i < A[0].Length; i++)
            {
                for (var j = 1; j < A.Length; j++)
                {
                    if (A[j][i] + '0' > A[j - 1][i] + '0')
                    {
                        res += 1;
                        break;
                    }
                }
            }

            return res;

        }
    }
}
