using LeetCode.Easy;
using System;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定二叉树的根节点 root，找出存在于不同节点 A 和 B 之间的最大值 V，其中 V = |A.val - B.val|，且 A 是 B 的祖先。

    （如果 A 的任何子节点之一为 B，或者 A 的任何子节点是 B 的祖先，那么我们认为 A 是 B 的祖先）


     */

    public class MaxAncestorDiff
    {


        public int Solution(TreeNode root)
        {
            if (root == null) return 0;
            var maxNode = root.val;
            var minNode = root.val;

            return dfs(root, maxNode, minNode);

        }

        private int dfs(TreeNode node, int maxNode, int minNode)

        {
            if (node == null)
            {
                return maxNode - minNode;
            }

            minNode = Math.Min(node.val, minNode);
            maxNode = Math.Max(node.val, maxNode);
            return Math.Max(dfs(node.left, maxNode, minNode), dfs(node.right, maxNode, minNode));

        }
    }

}

