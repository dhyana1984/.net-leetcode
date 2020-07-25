using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 给出一棵二叉树，其上每个结点的值都是 0 或 1 。每一条从根到叶的路径都代表一个从最高有效位开始的二进制数。例如，如果路径为 0 -> 1 -> 1 -> 0 -> 1，那么它表示二进制数 01101，也就是 13 。

    对树上的每一片叶子，我们都要找出从根到该叶子的路径所表示的数字。

    以 10^9 + 7 为模，返回这些数字之和。
     */

    public class SumRootToLeaf
        {
        int sum = 0;
        string str = "";
        public int Solution(TreeNode root)
        {
            if (root == null)
                return 0;
            PreOrder(root);
            return sum;


        }

        private void PreOrder(TreeNode root)
        {
            if (root == null)
                return;
            str += root.val.ToString();
            if (root.left == null && root.right == null)
            {
                sum += Convert.ToInt32(str, 2);
                str = str.Substring(0, str.Length - 1);
                return;
            }
            PreOrder(root.left);
     
            PreOrder(root.right);
            str = str.Substring(0, str.Length - 1);
        }
    }
}
