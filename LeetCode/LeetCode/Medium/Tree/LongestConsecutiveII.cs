using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一个二叉树，你需要找出二叉树中最长的连续序列路径的长度。

    请注意，该路径可以是递增的或者是递减。例如，[1,2,3,4] 和 [4,3,2,1] 都被认为是合法的，而路径 [1,2,4,3] 则不合法。另一方面，路径可以是 子-父-子 顺序，并不一定是 父-子 顺序。

    示例 1:

    输入:
            1
           / \
          2   3
    输出: 2
    解释: 最长的连续路径是 [1, 2] 或者 [2, 1]。
 

    示例 2:

    输入:
            2
           / \
          1   3
    输出: 3
    解释: 最长的连续路径是 [1, 2, 3] 或者 [3, 2, 1]。
 

    注意: 树上所有节点的值都在 [-1e7, 1e7] 范围内。


     */
    public class LongestConsecutiveII
    {

        public int Solution(TreeNode root)
        {
            if (root == null)
                return 0;
            int leftAsc = root.left != null && root.left.val - root.val == 1 ? GetMaxPath(root.left, 1) + 1 : 1;
            int rightAsc = root.right != null && root.right.val - root.val == 1 ? GetMaxPath(root.right, 1) + 1 : 1;
            int leftDesc = root.left != null && root.left.val - root.val == -1 ? GetMaxPath(root.left, -1) + 1 : 1;
            int rightDesc = root.right != null && root.right.val - root.val == -1 ? GetMaxPath(root.right, -1) + 1 : 1;

            return Math.Max(Math.Max(Math.Max(leftAsc + rightDesc - 1, leftDesc + rightAsc - 1), Solution(root.left)), Solution(root.right));
        }


        private int GetMaxPath(TreeNode node, int diff)
        {
            if (node == null) return 0;
            int max = 1;
            if (node.left != null && node.left.val - node.val == diff)
            {
                max = Math.Max(GetMaxPath(node.left, diff) + 1, max);
            }
            if (node.right != null && node.right.val - node.val == diff)
            {
                max = Math.Max(GetMaxPath(node.right, diff) + 1, max);
            }
            return max;

        }

    }
}
