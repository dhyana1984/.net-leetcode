using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy.Easy
{

   public class LargestSumAfterKNegations
    {
        public int Solution(int[] A, int K)
        {
            var i = 0;
            while (i < K)
            {
                i++;
                var index = Array.IndexOf(A,A.Min());
                A[index] *= -1;
            }
            return A.Sum();
        }
    }
}
