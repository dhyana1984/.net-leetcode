using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一个二叉搜索树，编写一个函数 kthSmallest 来查找其中第 k 个最小的元素。

    说明：
    你可以假设 k 总是有效的，1 ≤ k ≤ 二叉搜索树元素个数。

    示例 1:

    输入: root = [3,1,4,null,2], k = 1
       3
      / \
     1   4
      \
       2
    输出: 1
    示例 2:

    输入: root = [5,3,6,2,4,null,null,1], k = 3
           5
          / \
         3   6
        / \
       2   4
      /
     1
    输出: 3


     */
    public class KthSmallest
    {
        int result = 0;
        int index = 1;
        //List<int> list= new List<int>();
        public int Solution(TreeNode root, int k)
        {
            InOrder(root, k);
            //InOrder(root);
            //return list[k-1];
            return result;
        }

        private void InOrder(TreeNode node, int k)
        //private void InOrder(TreeNode node)
        {
            if (node == null)
                return;
            InOrder(node.left, k);
            //InOrder( node.left);
            if (index++ == k)
                result = node.val;

            //list.Add(node.val);
            InOrder(node.right, k);
            //InOrder( node.right);
            

        }
    }
}
