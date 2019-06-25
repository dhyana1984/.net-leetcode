using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 您需要在二叉树的每一行中找到最大的值。

        示例：

        输入: 

                  1
                 / \
                3   2
               / \   \  
              5   3   9 

        输出: [1, 3, 9]

     */

    public class LargestValues
    {
        public IList<int> Solution(TreeNode root)
        {
            IList<int> list = new List<int>();
            if (root == null)
                return list;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int count = 0;
            int max = int.MinValue;
            TreeNode node = null;
            while (queue.Any())
            {
                count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    node = queue.Dequeue();
                    max = Math.Max(max, node.val);
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                list.Add(max);
                max = int.MinValue;
            }
            return list;

        }


    }
}
