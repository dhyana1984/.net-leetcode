using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public class PreOrderInOrderBuildTree
    {
        int pre_idx = 0;
        int[] preorder;
        int[] inorder;
        Dictionary<int, int> idx_map = new Dictionary<int, int>();
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            this.preorder = preorder;
            this.inorder = inorder;
            var idx = 0;
            foreach (var item in inorder)
            {
                idx_map[item] = idx++;
            }

            return helper(0, inorder.Length);


        }
    
        private TreeNode helper(int left, int right)
        {
            if (left == right)
                return null;
            var root_val = preorder[pre_idx];
            var root = new TreeNode(root_val);

            var index = idx_map[root_val];

            pre_idx++;
            root.left = helper(left, index);
            root.right = helper(index + 1, right);
            return root;
        }
    }
}
