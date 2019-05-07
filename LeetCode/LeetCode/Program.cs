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
            TreeNode t1 = new TreeNode(3);
            t1.left = new TreeNode(9);
            t1.right = new TreeNode(20);
            t1.right.left = new TreeNode(15);
            t1.right.right = new TreeNode(7);
            //TreeNode t2= new TreeNode(1);
            //t2.left = new TreeNode(2);
            //t2.right = new TreeNode(3); 
            //t2.left.left = null;

            BinTreeLevelOrder solution = new BinTreeLevelOrder();
           var aaaa= solution.Solution(t1);
        }
    }
}
