using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium.Tree
{
    public class BTRob
    {
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        int sum1 = 0;
        int sum2 = 0;
        TreeNode theRoot = null;
        Dictionary<TreeNode, bool> dict = new Dictionary<TreeNode, bool>();
        public int Solution(TreeNode root)
        {
            if (root == null)
                return 0;
            theRoot = root;
            InOrder(root, root);
            sum1 = dict.Where(t => t.Value).Sum(t => t.Key.val);
            sum2= dict.Where(t => !t.Value).Sum(t => t.Key.val);
            return Math.Max(sum1, sum2);

        }


        private void InOrder(TreeNode node, TreeNode root)
        {
            if (node == null)
                return;
            if (node == root)
                dict[node] = true;
            else
                dict[node] = !dict[root];
            InOrder(node.left, node);
            InOrder(node.right, node);

            /*if (node == null)
                return;
            InOrder(node.left, node);
            if (flag)
                sum1 += node.val;
            else
                sum2 += node.val;
            if (root == theRoot && root.right == node || root != theRoot)
                flag = !flag;
            InOrder(node.right, node);
            if (node.left == null)
                flag = false;*/


        }
    }
}
