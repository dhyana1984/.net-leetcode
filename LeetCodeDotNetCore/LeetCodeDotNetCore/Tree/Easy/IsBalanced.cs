using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Easy.IsSameTree;

namespace LeetCode.Easy
{
    public class SolutionIsBalanced
    {
        public bool Solution(TreeNode root)
        {
            if (root == null)
                return true;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                TreeNode node = queue.Dequeue();
                if (MaxDepth(node.left) - MaxDepth(node.right) > 1 || MaxDepth(node.left) - MaxDepth(node.right) < -1)
                    return false;
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            return true;
        }
        private int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);
            return Math.Max(left, right) + 1;
        }

    }
}

