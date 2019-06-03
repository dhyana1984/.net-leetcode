using LeetCode.Easy;
using LeetCode.Helper;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Easy.IsSameTree;
using static LeetCode.Medium.SolutionAddTwoNumbers;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t1 = new TreeNode(4);
            t1.left = new TreeNode(2); ;
            t1.right = new TreeNode(6);

            t1.left.left = new TreeNode(1);
            t1.left.right = new TreeNode(3);
          
            //t1.right.right = new TreeNode(4);
            //t1.left.left.left = new TreeNode(0);
            //t1.left.left.right = new TreeNode(2);
            //t1.left.right.left = new TreeNode(0);
            //t1.right.right.right = new TreeNode(1);
            ////t1.right.right.left = new TreeNode(1);
            //t1.right.right.right.left = new TreeNode(1);
            //t1.right.right.right.right = new TreeNode(2);

            //TreeNode t2 = new TreeNode(4);
            //t2.left = new TreeNode(1);
            //t2.right = new TreeNode(2);

            //t2.right.right = new TreeNode(1);
            //t2.right.right.left= new TreeNode(1);
            //t2.right.right.right = new TreeNode(2);

            TreeNode root =TreeGenerater.GetRoot(new List<int?>() { 90, 69, null, 49, 89, null, 52, null, null, null, null});
            MinDiffInBST solution = new MinDiffInBST();
           var aaaa= solution.Solution(t1);
        }
    }
}
