using LeetCode.Easy;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Medium.SolutionAddTwoNumbers;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] aaa = new int[]{ 1, 2, 3 };
            string result = string.Join("",aaa);
            aaa = aaa.Skip<int>(1).ToArray();
        }
    }
}
