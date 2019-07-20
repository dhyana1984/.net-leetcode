using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
   
    public class PreOrderAndPostOrderBuildTree
    {

        //返回与给定的前序和后序遍历匹配的任何二叉树。
        int[] pre, post;
        public TreeNode ConstructFromPrePost(int[] pre, int[] post)
        {
            this.pre = pre;
            this.post = post;
            return Make(0, 0, pre.Length);



        }

        public TreeNode Make(int preIndex, int postIndex, int N)
        {
            if (N == 0) return null;
            TreeNode root = new TreeNode(pre[preIndex]);
            if (N == 1) return root;

            int L = 1;
            for (; L < N; ++L)
                if (post[postIndex + L - 1] == pre[preIndex + 1])
                    break;

            root.left = Make(preIndex + 1, postIndex, L);
            root.right = Make(preIndex + L + 1, postIndex + L, N - 1 - L);
            return root;
        }




    }
}
