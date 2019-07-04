using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一棵有 n 个结点的二叉树，你的任务是检查是否可以通过去掉树上的一条边将树分成两棵，且这两棵树结点之和相等。

        样例 1:

        输入:     
            5
           / \
          10 10
            /  \
           2   3

        输出: True
        解释: 
            5
           / 
          10
      
        和: 15

           10
          /  \
         2    3

        和: 15
 

        样例 2:

        输入:     
            1
           / \
          2  10
            /  \
           2   20

        输出: False
        解释: 无法通过移除一条树边将这棵树划分成结点之和相等的两棵子树。
 

        注释 :

        树上结点的权值范围 [-100000, 100000]。
        1 <= n <= 10000
 

     */

    public class CheckEqualTree
    {
        bool flag = false;
        TreeNode theRoot = null;
        public bool Solution(TreeNode root)
        {
            if (root == null || root.left == null && root.right == null)
                return false;
            var sum = GetTreeSum(root);
            theRoot = root;
            if (sum % 2 != 0)
                return false;
            var half = sum / 2;
            CheckSumValue(root, half);

            return flag;

        }

        private int CheckSumValue(TreeNode node, int target)
        {
            if (node == null)
                return 0;
            var sum = CheckSumValue(node.left, target) + CheckSumValue(node.right, target) + node.val; //找节点和是原树节点和一半的子树
            flag = sum == target || flag;           
            if (target == 0)        //如果原树节点和是0，需要特殊处理
            {
                if (sum == 0 && node == theRoot)    //当子树是原树本身，判断左右子树和是否相等，若相等才满足条件
                    flag = flag && GetTreeSum(node.left) == GetTreeSum(node.right);
            }
            return sum;
        }

        private int GetTreeSum(TreeNode node)
        {
            if (node == null)
                return 0;
            return GetTreeSum(node.left) + GetTreeSum(node.right) + node.val;
        }
    }
}
