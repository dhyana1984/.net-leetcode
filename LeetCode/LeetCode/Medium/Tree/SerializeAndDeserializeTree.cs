using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    public class Codec
    {

        // Encodes a tree to a single string.
        public string Serialize(TreeNode root)
        {
            string  preOrder = "";
            PreOrder(root, ref preOrder);
            int[] int_InOrder = stringArrayToIntArray(preOrder);
            Array.Sort(int_InOrder);
            string inOrder = String.Join("", int_InOrder);
            return preOrder + "|"+ inOrder;
        }
        private void PreOrder(TreeNode node, ref string str)
        {
            if (node == null)
                return;
            str += node.val.ToString();

            PreOrder(node.left,ref str);
            PreOrder(node.right, ref str);
 
  

        }
        public static int[] stringArrayToIntArray(string str_arr)
        {
            // TODO Auto-generated method stub
            int[] arr = new int[str_arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(str_arr[i].ToString());
            }
            
            return arr;
        }

        int pre_idx = 0; //前序数组索引，从根开始
        int[] preorder;
        int[] inorder;
        Dictionary<int, int> idx_map = new Dictionary<int, int>();
        // Decodes your encoded data to tree.
        public TreeNode Deserialize(string data)
        {
            var idx = 0;
        
            preorder = stringArrayToIntArray(data.Split('|')[0]);
            inorder = stringArrayToIntArray(data.Split('|')[1]);

   
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
