﻿using LeetCode.Easy;
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
            TreeNode t1 = new TreeNode(2);
            t1.left = new TreeNode(0); ;
            t1.right = new TreeNode(3);

            t1.left.left = new TreeNode(-4);
            t1.left.right = new TreeNode(1);
            //t1.right.left = new TreeNode(5);
            //t1.right.right = new TreeNode(4);
            //t1.left.left.left = new TreeNode(7);
            //t1.left.left.right = new TreeNode(2);
            //t1.right.right.left = new TreeNode(1);


            ConvertBST solution = new ConvertBST();
           var aaaa= solution.Solution(t1);

            List<int> list = new List<int> { 1, 2, 3, 5 };
            var a = list.Max();
        }
    }
}
