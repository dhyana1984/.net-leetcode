using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给出二叉树的根，找出出现次数最多的子树元素和。一个结点的子树元素和定义为以该结点为根的二叉树上所有结点的元素之和（包括结点本身）。然后求出出现次数最多的子树元素和。如果有多个元素出现的次数相同，返回所有出现次数最多的元素（不限顺序）。

 

        示例 1
        输入:

          5
         /  \
        2   -3
        返回 [2, -3, 4]，所有的值均只出现一次，以任意顺序返回所有值。

        示例 2
        输入:

          5
         /  \
        2   -5
        返回 [2]，只有 2 出现两次，-5 只出现 1 次。

 

        提示： 假设任意子树元素和均可以用 32 位有符号整数表示。


     */
    public class FindFrequentTreeSum
    {
        List<int> list = new List<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int last=int.MinValue;
        int max = int.MinValue;
        public int[] Solution(TreeNode root)
        {
            preOrder(root, 0);

            var dicts =  dict.Where(t => t.Value == dict.Values.Max()).Select(t=>t.Key);
        
            return dicts.ToArray();
        }


        private int preOrder(TreeNode node, int sum)
        {
            if (node == null)
                return 0;
            sum = node.val + preOrder(node.left, sum) + preOrder(node.right, sum);
            if (!dict.ContainsKey(sum))
                dict[sum] = 1;
            else
                dict[sum] += 1;
            return sum;


        }

    
    }
}
