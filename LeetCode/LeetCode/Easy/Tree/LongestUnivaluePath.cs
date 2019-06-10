using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 给定一个二叉树，找到最长的路径，这个路径中的每个节点具有相同值。 这条路径可以经过也可以不经过根节点。

        注意：两个节点之间的路径长度由它们之间的边数表示。

        示例 1:

        输入:

                      5
                     / \
                    4   5
                   / \   \
                  1   1   5
        输出:

        2
        示例 2:

        输入:

                      1
                     / \
                    4   5
                   / \   \
                  4   4   5
        输出:

        2
     */
    public class LongestUnivaluePath
    {
 
        int result = 0;

        public int Solution(TreeNode root)
        {

            if (root == null)
                return 0;

            InOrder(root,root.val);
            return result;
        }

        private int InOrder(TreeNode node, int val)
        {
            if (node == null)
                return 0;


            int left = InOrder(node.left, node.val);

            int right = InOrder(node.right,node.val);
            
            result = Math.Max(result, left + right);

            if(node.val ==val)
                return Math.Max(left, right) + 1;

            return 0;



        }
    }
}
