using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 给定一个二叉树，返回所有从根节点到叶子节点的路径。

        说明: 叶子节点是指没有子节点的节点。

        示例:

        输入:

           1
         /   \
        2     3
         \
          5

        输出: ["1->2->5", "1->3"]

        解释: 所有根节点到叶子节点的路径为: 1->2->5, 1->3
     */
    public class AllBinaryTreePaths
    {
        IList<string> resultList = new List<string>();
        public IList<string> Solution(TreeNode root)
        {
            //遍历解题
            //if (root == null)
            //    return resultList;
            //var queue = new Queue<TreeNode>();
            //var dict = new Dictionary<TreeNode, string>();
            //dict[root] = root.val.ToString();
            //queue.Enqueue(root);
            //while (queue.Any())
            //{

            //    TreeNode node = queue.Dequeue();
            //    if (node.right == null && node.left == null)
            //        resultList.Add(dict[node]);
            //    if (node.left != null)
            //    {
            //        dict[node.left] = dict[node] + "->" + node.left.val.ToString();
            //        queue.Enqueue(node.left);
            //    }
            //    if (node.right != null)
            //    {
            //        dict[node.right] = dict[node] + "->" + node.right.val.ToString();
            //        queue.Enqueue(node.right);
            //    }



            //}

            //return resultList;

            //递归解题
            if (root == null)
                return resultList;
            Dictionary<TreeNode, string> dict = new Dictionary<TreeNode, string>();
            dict[root] = root.val.ToString();
            var node = GetPath(root, dict,root.val.ToString());
            return resultList;


        }

        private Dictionary<TreeNode, string> GetPath(TreeNode root, Dictionary<TreeNode, string> dict,string lastPath)
        {
            if (root != null)
            {
                dict[root] = lastPath;
                if (root.left != null)
                    dict[root.left] = dict[root] + "->" + GetPath(root.left,dict,dict[root] +"->"+root.left.val.ToString());

 
                if (root.right != null)
                    dict[root.right] = dict[root] + "->" + GetPath(root.right, dict, dict[root] + "->" + root.right.val.ToString());

                if (root.right == null && root.left == null)
                    resultList.Add(dict[root]);
            }
            return null;


        }
    }
}
