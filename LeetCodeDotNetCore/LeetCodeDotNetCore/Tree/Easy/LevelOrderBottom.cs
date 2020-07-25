using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Easy.IsSameTree;

namespace LeetCode.Easy
{
    /*给定一个二叉树，返回其节点值自底向上的层次遍历。 （即按从叶子节点所在层到根节点所在的层，逐层从左向右遍历）

        例如：
        给定二叉树 [3,9,20,null,null,15,7],

            3
           / \
          9  20
            /  \
           15   7
        返回其自底向上的层次遍历为：

        [
          [15,7],
          [9,20],
          [3]
        ]
     */
    public class LevelOrderBottom
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
            resultList.Reverse();
            return resultList;
        }
    }
}
