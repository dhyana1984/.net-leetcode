using LeetCode.Biby;
using LeetCode.Easy;
using LeetCode.Helper;
using LeetCode.Medium;
using LeetCode.Medium.Tree;
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
            t1.left = new TreeNode(1);
            t1.right = new TreeNode(5);
            t1.left.left = new TreeNode(0);

            t1.left.right = new TreeNode(2);
            t1.right.left = new TreeNode(4);
            t1.right.right = new TreeNode(6);
            //t1.left.right.left = new TreeNode(7);
            t1.left.right.right = new TreeNode(3);
            //t1.left.left.left = new TreeNode(0);
            ////t1.left.left.right = new TreeNode(1);
            ////t1.left.left.left.left = new TreeNode(4);
            ////t1.left.left.left.left.left = new TreeNode(8);
            ////t1.left.left.left.left.left.left = new TreeNode(3);
            ////t1.left.left.left.left.left.left.left = new TreeNode(6);
            ////t1.left.left.left.left.left.left.left.left = new TreeNode(4);
            ////t1.left.left.left.left.left.left.left.left.left = new TreeNode(7);
            ////t1.left.left.right = new TreeNode(2);
            //t1.left.right.left = new TreeNode(7);
            //t1.left.right.right = new TreeNode(4);
            //t1.right.right.left = new TreeNode(5);
            //t1.right.right.right = new TreeNode(1);

            //t1.right.right.right = new TreeNode(9);
            //t1.right.right.right.left = new TreeNode(1);
            //t1.right.right.right.right = new TreeNode(2);

            //TreeNode t2 = new TreeNode(4);
            //t2.left = new TreeNode(1);
            //t2.right = new TreeNode(2);

            //t2.right.right = new TreeNode(1);
            //t2.right.right.left= new TreeNode(1);
            //t2.right.right.right = new TreeNode(2);

            //TreeNode root = TreeGenerater.GetRoot(new List<int?>() { 90, 69, null, 49, 89, null, 52, null, null, null, null });
            //PreOrderPostOrderBuildTree solution = new PreOrderPostOrderBuildTree();
            //int[] a1 = new int[]{ 9, 3, 15, 20, 7 };
            //int[] a2 = new int[] { 9, 15, 7, 20, 3 };
            //var aaaa = solution.BuildTree(a1,a2);
            var aaa = new int[] { 1,3,2};
            FindFrequentTreeSum solution = new FindFrequentTreeSum();
            var result = solution.Solution(t1);

            //GetMatchAmountList solution = new GetMatchAmountList();
            //List<int> list1 = new List<int> { 500,600,200,300,550 };
            //List<int> list2 = new List<int> { 100, 200, 300, 400, 500, 150, 250 };

            //var result1 = solution.Solution(list1, list2);
            //var result2 = solution.Solution(list2, list1);
        }
    }
}
