using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy.Tree
{
    /*
     * 给定一个不为空的二叉搜索树和一个目标值 target，请在该二叉搜索树中找到最接近目标值 target 的数值。

        注意：

        给定的目标值 target 是一个浮点数
        题目保证在该二叉搜索树中只会存在一个最接近目标值的数
        示例：

        输入: root = [4,2,5,1,3]，目标值 target = 3.714286

            4
           / \
          2   5
         / \
        1   3

        输出: 4

     */

    public class ClosestValueForBST
    {
        int result;
        public int Solution(TreeNode root, double target)
        {

            result = root.val;
            InOrder(root, root, target);
            return result;
        }

        private void InOrder(TreeNode node, TreeNode root, double target)
        {
            if (node == null)
                return;
            InOrder(node.left, node, target);
            result = Math.Abs(result - target) <= Math.Abs(node.val - target) ? result : node.val;
            InOrder(node.right, node, target);
        }
    }
}
