using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Easy.IsSameTree;

namespace LeetCode.Medium
{
    /*给定一个二叉树，返回其按层次遍历的节点值。 （即逐层地，从左到右访问所有节点）。

        例如:
        给定二叉树: [3,9,20,null,null,15,7],

            3
           / \
          9  20
            /  \
           15   7
        返回其层次遍历结果：

        [
          [3],
          [9,20],
          [15,7]
        ]
     */
    public class BinTreeLevelOrder
    {
        public IList<IList<int>> Solution(TreeNode root)
        {
            if (root == null)
                return new List<IList<int>>();
            var resultList = new List<IList<int>>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                var list = new List<int>();
                var count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    list.Add(node.val);
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
                resultList.Add(list);

            }

            return resultList;
        }
    }
}
