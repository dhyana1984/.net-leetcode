using System;
using System.Collections.Generic;

namespace LeetCodeDotNetCore.DP.Medium
{
    /*120
     * Given a triangle, find the minimum path sum from top to bottom. Each step you may move to adjacent numbers on the row below.

        For example, given the following triangle

        [
             [2],
            [3,4],
           [6,5,7],
          [4,1,8,3]
        ]
        The minimum path sum from top to bottom is 11 (i.e., 2 + 3 + 5 + 1 = 11).

        Note:

        Bonus point if you are able to do this using only O(n) extra space, where n is the total number of rows in the triangle.
    */
    public class Triangle
    {
        public int Solution(IList<IList<int>> triangle)
        {
            //自底向上遍历，从倒数第二层开始
            for (var i = triangle.Count - 1; i >= 0; i--)
                //从尾向头遍历，从每一层倒数第二个开始
                for (var j = triangle[i].Count - 1; j >= 0; j--)
                {
                    //如果不是最后一层，则比较，如果是最后一层则直接等于triangle[i][j]不变
                    if (i != triangle.Count - 1)
                    {
                        //状态转移方程
                        //从倒数第二行开始向下一层相邻的两个数相加后作比较
                        //得到这一层中每一个元素与下一层相邻两个数字相加后，比较小的那个结果，从而可以向上一直推到，知道得到最后的triangle[0][0]
                        triangle[i][j] = Math.Min(triangle[i + 1][j + 1], triangle[i + 1][j]) + triangle[i][j];
                    }

                }
            return triangle[0][0];
        }
    }
}
