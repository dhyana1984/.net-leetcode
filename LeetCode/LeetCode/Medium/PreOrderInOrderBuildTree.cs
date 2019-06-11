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
        int pre_idx = 0; //前序数组索引，从根开始
        int[] preorder;
        int[] inorder;
        Dictionary<int, int> idx_map = new Dictionary<int, int>();
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            this.preorder = preorder;
            this.inorder = inorder;
            var idx = 0;
            foreach (var item in inorder) //通过中序分割左右
            {
                idx_map[item] = idx++;
            }

            return helper(0, inorder.Length);//不用-1


        }
    
        private TreeNode helper(int left, int right)
        {
            if (left == right)
                return null;
            var root_val = preorder[pre_idx];   //前序定根
            var root = new TreeNode(root_val);

            var index = idx_map[root_val];      //找到中序的分割点

            pre_idx++;
            root.left = helper(left, index);        //前序 ，左子树不用-1
            root.right = helper(index + 1, right);  //但是有子树要+1
            return root;
        }
    }
}
