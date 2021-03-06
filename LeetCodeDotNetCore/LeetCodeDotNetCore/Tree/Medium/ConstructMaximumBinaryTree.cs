﻿using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 
     * 
     * 给定一个不含重复元素的整数数组。一个以此数组构建的最大二叉树定义如下：

        二叉树的根是数组中的最大元素。
        左子树是通过数组中最大值左边部分构造出的最大二叉树。
        右子树是通过数组中最大值右边部分构造出的最大二叉树。
        通过给定的数组构建最大二叉树，并且输出这个树的根节点。

        Example 1:

        输入: [3,2,1,6,0,5]
        输入: 返回下面这棵树的根节点：

             6
           /   \
          3     5
           \    / 
            2  0   
              \
               1

     */
    public class ConstructMaximumBinaryTree
    {
        public TreeNode Solution(int[] nums)
        {

            TreeNode root = new TreeNode(nums.Max());
            return Helper(nums, root);
            


        }

        private TreeNode Helper(int[] nums, TreeNode node)
        {
            if (nums.Count() == 0)
            {
                return null;
            }
            var max = nums.Max();
            var leftNums = nums.Skip(0).Take(Array.IndexOf(nums, max)).ToArray();
            var rightNums = nums.Skip(Array.IndexOf(nums, max)+1).Take(nums.Count() - leftNums.Count()).ToArray();
            node = new TreeNode(max);
           
            node.left = Helper(leftNums, node.left);

            node.right = Helper(rightNums, node.right);
            return node;
        }
    }
}
