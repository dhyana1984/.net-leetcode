using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public  class InOrderPostOrderBuildTree
    {
        int[] inorder;
        int[] postorder;
        Dictionary<int, int> mapDict = new Dictionary<int, int>();
        int postIndex; //后序数组索引
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {


            this.postorder = postorder;
            this.inorder = inorder;

            postIndex = this.postorder.Length - 1;  //从根开始
            int index = 0;
            foreach (var item in inorder) //通过中序分割左右
            {
                mapDict[item] = index++;
            }

            return helper(0, postorder.Length-1);//
        }

        private TreeNode helper(int left, int right)
        {
            if (left > right)
                return null;

            var rootVal = postorder[postIndex];     //后序定根
            var root = new TreeNode(rootVal);
            
            var index = mapDict[rootVal];           //找到根的分割点
            postIndex--;                            //处理第二个根
            root.right = helper(index+1 , right);   //因为是后序，所以在还原子树的时候，需要对位置调整，右子树+1，左子树-1
            root.left = helper(left, index-1);
         
            
            return root;

        }
    }
    }

