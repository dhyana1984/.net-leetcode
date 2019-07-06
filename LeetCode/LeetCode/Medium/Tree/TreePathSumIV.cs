using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 对于一棵深度小于 5 的树，可以用一组三位十进制整数来表示。

        对于每个整数：

        百位上的数字表示这个节点的深度 D，1 <= D <= 4。
        十位上的数字表示这个节点在当前层所在的位置 P， 1 <= P <= 8。位置编号与一棵满二叉树的位置编号相同。
        个位上的数字表示这个节点的权值 V，0 <= V <= 9。
        给定一个包含三位整数的升序数组，表示一棵深度小于 5 的二叉树，请你返回从根到所有叶子结点的路径之和。

        样例 1:

        输入: [113, 215, 221]
        输出: 12
        解释: 
        这棵树形状如下:
            3
           / \
          5   1

        路径和 = (3 + 5) + (3 + 1) = 12.
 

        样例 2:

        输入: [113, 221]
        输出: 4
        解释: 
        这棵树形状如下: 
            3
             \
              1

        路径和 = (3 + 1) = 4.


     */

    public class TreePathSumIV
    {
        public int Solution(int[] nums)
        {
            if (nums.Count() == 0)
                return 0;
            else if (nums.Count() == 1)
                return nums[0] % 10;
            var dict = new Dictionary<int, int>();
            //使用字典，百位十位作为键，父节点+当前节点的值作为字典值
            dict[nums[0] / 10] = nums[0] % 10;
            for (int i = 1; i < nums.Count(); i++)
            {
                var ten = nums[i] / 10;
                var hundred = nums[i] / 100;
                var one = nums[i] % 10;
                //获取父节点的十位即父节点的位置
                var parentIndex = (ten % 10) % 2 == 0 ? ten % 10 / 2 : ten % 10 / 2 + 1;
                //父节点的值+当前节点的值作为当前字典的值，键是当前三位数的前两位
                dict[ten] = dict[(hundred - 1) * 10 + parentIndex] + one;

            }
            //累加所有根节点的字典值，即可获得最终结果
            return dict.Where(t =>
                              !dict.ContainsKey((t.Key % 10) * 2 - 1 + ((t.Key / 10) + 1) * 10) //判断没有左子节点
                           && !dict.ContainsKey((t.Key % 10) * 2 + ((t.Key / 10) + 1) * 10))    //判断没有右子节点
                       .Sum(t => t.Value);

        }

    }
}

