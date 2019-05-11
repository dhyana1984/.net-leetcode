using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Easy.IsSameTree;

namespace LeetCode.Easy
{
    /*给定一个二叉树和一个目标和，判断该树中是否存在根节点到叶子节点的路径，这条路径上所有节点值相加等于目标和。

    说明: 叶子节点是指没有子节点的节点。

    示例: 
    给定如下二叉树，以及目标和 sum = 22，

                  5
                 / \
                4   8
               /   / \
              11  13  4
             /  \      \
            7    2      1
    返回 true, 因为存在目标和为 22 的根节点到叶子节点的路径 5->4->11->2。
*/
   public class BinTreeHasPathSum
    {
        public bool Solution(TreeNode root, int sum)
        {
          
            if (root == null)
                return false;
            else
            {
                var result = FindLeftNode(root, 0, sum); 
                return result;
            }
        }

        private bool FindLeftNode(TreeNode node, int val,int sum)
        {
            if (node != null && node.left == null && node.right == null)
                return val + node.val == sum;
            else if (node != null)
            {
                int result = val + node.val;
                return FindLeftNode(node.left, result, sum)
                               || FindLeftNode(node.right, result, sum);
            }
            else
                return false;
        }
    }
}
