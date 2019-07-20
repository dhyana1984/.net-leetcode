using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 给定一个二叉树和一个目标和，找到所有从根节点到叶子节点路径总和等于给定目标和的路径。

        说明: 叶子节点是指没有子节点的节点。

        示例:
        给定如下二叉树，以及目标和 sum = 22，

                      5
                     / \
                    4   8
                   /   / \
                  11  13  4
                 /  \    / \
                7    2  5   1
        返回:

        [
           [5,4,11,2],
           [5,8,4,5]
        ]

     */
    public class TreePathSum
    {
        public IList<IList<int>> Solution(TreeNode root, int sum)
        {
            var result = new List<IList<int>>();
            var stack = new Stack<TreeNode>();
            if(root!=null)
                stack.Push(root);
            var cur_Sum = sum;
            var resultItemList = new List<int>();
            var dictSum = new Dictionary<TreeNode, int>();
            var dictValue = new Dictionary<TreeNode, List<int>>();
            dictSum[root] = cur_Sum;
            dictValue[root] = new List<int> { root.val };
            while (stack.Any())
            {
                var node = stack.Pop();
                cur_Sum = dictSum[node] - node.val;

                resultItemList = dictValue[node];

                if (node.right != null)
                {
                    stack.Push(node.right);
                    dictSum[node.right] = cur_Sum;
                    var list = new List<int>(resultItemList);
                     list.Add(node.right.val);
                    dictValue[node.right] = list;
                }
                if (node.left != null)
                {
                    stack.Push(node.left);
                    dictSum[node.left] = cur_Sum;
                    var list = new List<int>(resultItemList);
                    list.Add(node.left.val);
                    dictValue[node.left] = list;
                }
                if (node.right == null && node.left == null)
                {
                    if (cur_Sum == 0)
                    {
                        result.Add(resultItemList);   
                    }

                }

            }
            return result;


        }
    }
}
