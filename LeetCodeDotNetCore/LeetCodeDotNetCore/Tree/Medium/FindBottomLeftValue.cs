using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一个二叉树，在树的最后一行找到最左边的值。

        示例 1:

        输入:

            2
           / \
          1   3

        输出:
        1
 

        示例 2:

        输入:

                1
               / \
              2   3
             /   / \
            4   5   6
               /
              7

        输出:
        7

     */

    public class FindBottomLeftValue
    {
        public int Solution(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var count = 0;
            TreeNode node = null;
            var flag = true;
            var result = 0;
            while (queue.Any())
            {
                flag = true;
                count = queue.Count;
                for (int i = 0; i < count; i++)
                {

                    node = queue.Dequeue();
                    if (i == 0)
                        result = node.val;
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                    flag = flag && node.left == null && node.right == null;

                }
                if (flag)
                    return result;

            }
            return 0;


        }
    }
}
