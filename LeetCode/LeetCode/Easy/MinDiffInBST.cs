using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class MinDiffInBST
    {
        List<int> list = new List<int>();
        int result = int.MaxValue;
        public int Solution(TreeNode root)
        {

            if (root == null)
                return 0;

            InOrder(root);

            return result;



        }

        private void InOrder(TreeNode root)
        {

            if (root == null)
                return;
            int left = int.MaxValue;
            int right = int.MaxValue;
            InOrder(root.left);
            if (root.left != null)
                left = Math.Abs(root.val - root.left.val);
            if (root.right != null)
                right = Math.Abs(root.val - root.right.val);

            result = Math.Min(Math.Min(left, right), result) ;
            InOrder(root.right);



        }

        //List<int> list = new List<int>();
        //public int Solution(TreeNode root)
        //{

        //    if (root == null)
        //        return 0;
        //    int result = int.MaxValue;
        //    InOrder(root);
        //    for (int i = 0; i < list.Count - 1; i++)
        //    {
        //        if (Math.Abs(list[i + 1] - list[i]) == 1)
        //            return 1;
        //        else
        //            result = Math.Min(result, Math.Abs(list[i + 1] - list[i]));

        //    }
        //    return result;



        //}

        //private void InOrder(TreeNode root)
        //{

        //    if (root == null)
        //        return;

        //    InOrder(root.left);
        //    list.Add(root.val);
        //    InOrder(root.right);



        //}
    }
}
