using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 给定一个非空二叉树, 返回一个由每层节点平均值组成的数组.

    示例 1:

    输入:
        3
       / \
      9  20
        /  \
       15   7
    输出: [3, 14.5, 11]
    解释:
    第0层的平均值是 3,  第1层是 14.5, 第2层是 11. 因此返回 [3, 14.5, 11].
     */
    public class AverageOfLevels
    {
        public IList<double> Solution(TreeNode root)
        {
            IList<double> resultList = new List<double>();
            if (root != null)
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                TreeNode node;

                while (queue.Any())
                {
                    int count = queue.Count;
                    resultList.Add(queue.Average(t => t.val));
                    for (int i = 0; i < count; i++)
                    {
                        node = queue.Dequeue();
                        if (node.left != null)
                            queue.Enqueue(node.left);
                        if (node.right != null)
                            queue.Enqueue(node.right);
                    }

                }
            }
            return resultList;
        }
    }
}
