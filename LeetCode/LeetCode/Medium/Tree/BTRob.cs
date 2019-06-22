using LeetCode.Easy;
using System;
using System.Collections.Generic;

namespace LeetCode.Medium.Tree
{
    public class BTRob
    {
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        int sum1 = 0;
        int sum2 = 0;
        bool flag = true;
        public int Solution(TreeNode root)
        {
            if (root == null)
                return 0;
            InOrder(root);
            return Math.Max(sum1, sum2);

        }


        private void InOrder(TreeNode node)
        {
            if (node == null)
                return;
            InOrder(node.left);
            if (flag)
            {
                sum1 += node.val;
                flag = false;
            }
            else
            {
                sum2 += node.val;
                flag = true;
            }

            InOrder(node.right);

        }
    }
}
