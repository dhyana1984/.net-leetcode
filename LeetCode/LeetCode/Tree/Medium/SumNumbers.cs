using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一个二叉树，它的每个结点都存放一个 0-9 的数字，每条从根到叶子节点的路径都代表一个数字。

        例如，从根到叶子节点路径 1->2->3 代表数字 123。

        计算从根到叶子节点生成的所有数字之和。

        说明: 叶子节点是指没有子节点的节点。

        示例 1:

        输入: [1,2,3]
            1
           / \
          2   3
        输出: 25
        解释:
        从根到叶子节点路径 1->2 代表数字 12.
        从根到叶子节点路径 1->3 代表数字 13.
        因此，数字总和 = 12 + 13 = 25.
        示例 2:

        输入: [4,9,0,5,1]
            4
           / \
          9   0
         / \
        5   1
        输出: 1026
        解释:
        从根到叶子节点路径 4->9->5 代表数字 495.
        从根到叶子节点路径 4->9->1 代表数字 491.
        从根到叶子节点路径 4->0 代表数字 40.
        因此，数字总和 = 495 + 491 + 40 = 1026.

     */

    public class Solution
    {
        int sum = 0;
        public int SumNumbers(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return root.val;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode node = null;
            var dict = new Dictionary<TreeNode, int>();
            dict[root] = root.val;
            var count = 0;
            while (queue.Any())
            {
                count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    node = queue.Dequeue();

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                        dict[node.left] = dict[node] * 10 + node.left.val;
                        if (node.left.left == null && node.left.right == null)
                            sum += dict[node.left];
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                        dict[node.right] = dict[node] * 10 + node.right.val;
                        if (node.right.left == null && node.right.right == null)
                            sum += dict[node.right];
                    }
                    
                }

            }
            return sum;
        }
    }
}
