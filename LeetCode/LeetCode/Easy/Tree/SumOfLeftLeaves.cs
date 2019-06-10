using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class SumOfLeftLeaves
    {

        //int sum = 0;
        public int Solution(TreeNode root)
        {
            //if (root == null)
            //    return 0;
            //if (root.left != null)
            //{
            //Solution(root.left);
            //    if (root.left.left == null && root.left.right == null)
            //        sum += root.left.val;

            //}
            //if (root.right != null)
            //{
            //    Solution(root.right);
            //}

            //return sum;

            if (root == null)
                return 0;
            int sum = 0;
            if (root.left != null)
            {
                if (root.left.left == null && root.left.right == null)
                    sum = root.left.val;
            }
            sum += Solution(root.left) + Solution(root.right);
            return sum;
        }
    }

}

