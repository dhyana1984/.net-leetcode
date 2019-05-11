using LeetCode.Easy;
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
            TreeNode t1 = new TreeNode(1);
            t1.left = new TreeNode(2); ;
            //t1.right = new TreeNode(8);

            //t1.left.left = new TreeNode(11);

            //t1.right.left = new TreeNode(13);
            //t1.right.right = new TreeNode(4);
            //t1.left.left.left = new TreeNode(7);
            //t1.left.left.right = new TreeNode(2);
            //t1.right.right.left = new TreeNode(1);


            BinTreeHasPathSum solution = new BinTreeHasPathSum();
           var aaaa= solution.Solution(t1,1);
        }
    }
}
