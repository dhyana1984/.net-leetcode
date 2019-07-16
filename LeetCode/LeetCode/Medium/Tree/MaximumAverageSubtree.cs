using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给你一棵二叉树的根节点 root，找出这棵树的 每一棵 子树的 平均值 中的 最大 值。

       子树是树中的任意节点和它的所有后代构成的集合。

      树的平均值是树中节点值的总和除以节点数。

     */

    public class MaximumAverageSubtree
    {
        double max = int.MinValue;
        double sum = 0;
        int count = 0;
        public double Solution(TreeNode root)
        {
            Helper(root);

            return max;

        }

        //第二层递归，求当前节点子树的和与子树个数
        private void SumForSubTree(TreeNode root)
        {
            if (root == null)
                return;
            SumForSubTree(root.left);
            sum += root.val;    //求和
            count += 1;         //子树节点个数累加
            SumForSubTree(root.right);



        }
        //第一层递归，求每个节点的子树的平均值，并且保存最大平均值
        private void Helper(TreeNode root)
        {
            if (root == null)
                return;
            Helper(root.left);
            sum = 0;
            count = 0;              //每个节点求平均值之前清零之前的求和以及节点个数
            SumForSubTree(root);    //每个节点求品均值
            max = Math.Max(max, sum / count);//并且保存平均值
            Helper(root.right);
        }
    }
}
