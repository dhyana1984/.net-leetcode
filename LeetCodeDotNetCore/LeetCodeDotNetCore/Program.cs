﻿using LeetCode.Easy;
using LeetCode.Easy.Stack;
using LeetCode.Greedy.Easy;
using LeetCode.Greedy.Medium;
using LeetCode.Heap.Easy;
using LeetCode.Helper;
using LeetCode.Medium;
using LeetCode.Medium.Tree;
using LeetCode.Stack.Easy;
using LeetCode.Stack.Medium;
using LeetCodeDotNetCore;
using LeetCodeDotNetCore.DP.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Easy.IsSameTree;

namespace LeetCode
{
    class Program
    {
        static int a = 1;
        private static void f1(int n)
        {
           
            int b = 1;
            Console.WriteLine(a += n);
            Console.WriteLine(b += n);
          
        }
        static void Main(string[] args)
        {
            TreeNode t1 = new TreeNode(1);
            t1.left = new TreeNode(2);
            t1.right = new TreeNode(3);
            t1.left.left = new TreeNode(4);
            t1.left.right = new TreeNode(5);
            t1.right.left = new TreeNode(6);
            //t1.right.right = new TreeNode(7);
            //t1.left.left = new TreeNode(43);

            //t1.left.right = new TreeNode(3);

            //t1.right.right = new TreeNode(1);
            //t1.left.left.left = new TreeNode(39);
            ////t1.left.left.right = new TreeNode(3);
            //t1.left.right.left = new TreeNode(4);
            //t1.left.right.right = new TreeNode(7);
            ////t1.left.left.left = new TreeNode(0);
            //t1.right.left.left = new TreeNode(4);
            //t1.right.right.left = new TreeNode(13);
            ////t1.left.left.right = new TreeNode(1);
            ////t1.left.left.left.left = new TreeNode(4);
            ////t1.left.left.left.left.left = new TreeNode(8);
            ////t1.left.left.left.left.left.left = new TreeNode(3);
            ////t1.left.left.left.left.left.left.left = new TreeNode(6);
            ////t1.left.left.left.left.left.left.left.left = new TreeNode(4);
            ////t1.left.left.left.left.left.left.left.left.left = new TreeNode(7);
            ////t1.left.left.right = new TreeNode(2);
            //t1.left.right.right = new TreeNode(4);
            //t1.right.right.left = new TreeNode(3);
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
            var aaa = new int[] { 113, 215, 221 };
            var bbb = new int[][]
            { new int[] { 9, 10 },
            new int[] { 5, 8 },
            new int[]{2, 6 },
            new int[]{1, 5 },
            new int[]{3, 8 },
            new int[]{4, 9 },
            new int[]{8, 10 },
            new int[]{4, 10 },
            new int[]{6, 8 },
            new int[]{7, 9 } };
            //IsCompleteTree solution = new IsCompleteTree();
            //var result = solution.Solution(t1);

            //GetMatchAmountList solution = new GetMatchAmountList();
            //List<int> list1 = new List<int> { 500,600,200,300,550 };
            //List<int> list2 = new List<int> { 100, 200, 300, 400, 500, 150, 250 };

            //var result1 = solution.Solution(list1, list2);
            //var result2 = solution.Solution(list2, list1);

            // PathInZigZagTree solution = new PathInZigZagTree();
            //var Result = solution.Solution(26);
            string[] a = new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
            int[] b = new int[] { 7, -2, -2, 7, 5 };
            int[][] c = new int[][] 
            {
                new int[] { -3, 2 },
                new int[] { -2,1 },
                new int[] {0,1},
                new int[] { -2,4 },
                new int[] { 1,0 },
                new int[] { -2, -3 },
                new int[] { 0,-3 },
                new int[] { 4,4 },
                new int[] { -3,3 },
                new int[] { 2,2},
            };
            //EvalRPN solution = new EvalRPN();
            //var result = solution.Solution(a);



            //MaximumSubarray solution = new MaximumSubarray();
            //var res = solution.Solution(new int[] { -3, -1, 3, 5, 1, -2, 1, 5, -4});

            KeyboardRow solution = new KeyboardRow();
            var input = new List<string> { "Hello", "Alaska", "Dad", "Peace" };
            var res = solution.Solution(input.ToArray());

            Console.WriteLine(res);
            Console.ReadLine();
        }

        private static void copyString (char[] to, char[] from)
        {
            for (int i = 0;from[i]!='\0'; ++i)
            {
                to[i] = from[i];
                to[i] = '\0';
             }
        }
        private static int Test(int a,int b)
        {
            a = b + 1;
            return a;
        }
      
    }
}
