using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Easy.IsSameTree;

namespace LeetCode.Easy
{
    public class MaxDepth
    {
        //给定一个二叉树，找出其最大深度。

        //二叉树的深度为根节点到最远叶子节点的最长路径上的节点数。

        //说明: 叶子节点是指没有子节点的节点。

        //示例：
        //给定二叉树[3, 9, 20, null, null, 15, 7]，

        //    3
        //   / \
        //  9  20
        //    /  \
        //   15   7
        //返回它的最大深度 3 。

        public int Solution(TreeNode root)
        {
            if (root == null)
                return 0;
            //else
            //{
            //    //递归求解
            //    int right = Solution(root.right);
            //    int left = Solution(root.left);
            //    return Math.Max(right, left) + 1;
            //}

            //迭代求解 
            Queue<KeyValuePair<TreeNode, int>> queue = new Queue<KeyValuePair<TreeNode, int>>();
            queue.Enqueue(new KeyValuePair<TreeNode, int>(root, 1));
            int depth = 0;
            KeyValuePair<TreeNode, int> node = new KeyValuePair<TreeNode, int>();
            while (queue.Any())
            {
                node = queue.Dequeue();
                root = node.Key;
                int curr_depth = node.Value;
                if(root != null)
                {
                    depth = Math.Max(depth, curr_depth);
                    queue.Enqueue(new KeyValuePair<TreeNode, int>(root.left, curr_depth+1));
                    queue.Enqueue(new KeyValuePair<TreeNode, int>(root.right, curr_depth+1));
                }
            }
            return depth;

        }
    }
}
