using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public class PreOrderPostOrderBuildTree
    {
        int[] preorder;
        int[] postorder;
        Dictionary<int, int> mapDict = new Dictionary<int, int>();
        int preIndex = 0;
        public TreeNode BuildTree(int[] pre, int[] post)
        {
            preorder = pre;
            postorder = post;
            var index = 0;
            foreach (var item in postorder)
            {
                mapDict[item] = index++;
            }

            return helper(0, preorder.Length-1);

        }

        private TreeNode helper(int left, int right)
        {
            if (left > right)
                return null;
            var rootVal = preorder[preIndex];
            var root = new TreeNode(rootVal);
            var postIndex = mapDict[rootVal];
            preIndex++;
            root.left = helper(left, postIndex);
            root.right = helper(postIndex + 1, right);
            return root;


        }
    }
}
