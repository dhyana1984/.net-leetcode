using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给出一个完全二叉树，求出该树的节点个数。

        说明：

        完全二叉树的定义如下：在完全二叉树中，除了最底层节点可能没填满外，其余每层节点数都达到最大值，并且最下面一层的节点都集中在该层最左边的若干位置。若最底层为第 h 层，则该层包含 1~ 2h 个节点。

        示例:

        输入: 
            1
           / \
          2   3
         / \  /
        4  5 6

        输出: 6

     */
    public class CountNodes
    {
        public int Solution(TreeNode root)
        {
            if (root == null)
                return 0;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode node = null;
            int count = 0;
            int level = 0;
            int sum = 0;
            bool isEnqueued = false;
            while (queue.Any())
            {

                count = queue.Count;
                int leafCount = 0;
                isEnqueued = false;
                for (int i = 0; i < count; i++)
                {
                    node = queue.Dequeue();

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                        isEnqueued = true;

                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                        isEnqueued = true;

                    }
                    if (node.left == null && node.right == null &&!isEnqueued)
                        leafCount += 1;


                }
                if (node.left == null && node.right == null && !isEnqueued)
                    sum += leafCount;
                else
                    sum += Convert.ToInt16(Math.Pow(2, level));
                level++;

            }
            return sum;
        }
    }
}
