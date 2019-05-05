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
            t1.left = new TreeNode(2);
            t1.right = new TreeNode(3);

            TreeNode t2= new TreeNode(1);
            t2.left = new TreeNode(2);
            t2.right = new TreeNode(3); 
            t2.left.left = null;
     
            IsSameTree solution = new IsSameTree();
           bool aaaa= solution.Solution(t1,t2);
        }
    }
}
