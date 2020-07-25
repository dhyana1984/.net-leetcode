using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     给你一棵指定的二叉树，请你计算它最长连续序列路径的长度。

        该路径，可以是从某个初始结点到树中任意结点，通过「父 - 子」关系连接而产生的任意路径。

        这个最长连续的路径，必须从父结点到子结点，反过来是不可以的。

        示例 1：

        输入:

           1
            \
             3
            / \
           2   4
                \
                 5

        输出: 3

        解析: 当中，最长连续序列是 3-4-5，所以返回结果为 3
        示例 2：

        输入:

           2
            \
             3
            / 
           2    
          / 
         1

        输出: 2 

        解析: 当中，最长连续序列是 2-3。注意，不是 3-2-1，所以返回 2。

         */

    public class LongestConsecutive
    {
        int result = 1; //只有1个元素时就是返回1
        int last;          //找到一个连续序列节点时，保存节点值
        public int Solution(TreeNode root)
        {
            if (root == null)
                return 0;      //边界情况，根为null，返回0
            last = root.val;  //初始情况，第一个连续序列的元素就是根节点的值
            PreOrder(root, root, 1); //开始递归，传连续序列初始值1
            return result;
        }

        private void PreOrder(TreeNode node, TreeNode root, int count)
        {
            if (node == null)
                return;
            if (node.val - root.val == 1 && last != node.val) //如果子节点的值减去父节点的值等于1，并且是第一次获得连续序列的子节点则++count，防止父节点是1，左右子节点都是2的情况，count会重复累加
            {

                result = Math.Max(result, ++count);
                last = node.val;                                          //last赋值当前第一个连续序列的子节点值
            }
            if (node.val - root.val != 1)                              //如果不连续。给last赋值当前节点的根节点值，count置1，重新开始找连续序列
            {
                last = root.val;
                count = 1;
            }
            PreOrder(node.left, node, count);

            PreOrder(node.right, node, count);
        }
    }

}
