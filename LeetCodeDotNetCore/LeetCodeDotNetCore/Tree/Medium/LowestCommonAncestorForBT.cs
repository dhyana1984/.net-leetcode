using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一个二叉树, 找到该树中两个指定节点的最近公共祖先。

    百度百科中最近公共祖先的定义为：“对于有根树 T 的两个结点 p、q，最近公共祖先表示为一个结点 x，满足 x 是 p、q 的祖先且 x 的深度尽可能大（一个节点也可以是它自己的祖先）。”

    例如，给定如下二叉树:  root = [3,5,1,6,2,0,8,null,null,7,4]



 

    示例 1:

    输入: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 1
    输出: 3
    解释: 节点 5 和节点 1 的最近公共祖先是节点 3。
    示例 2:

    输入: root = [3,5,1,6,2,0,8,null,null,7,4], p = 5, q = 4
    输出: 5
    解释: 节点 5 和节点 4 的最近公共祖先是节点 5。因为根据定义最近公共祖先节点可以为节点本身。
 

    说明:

    所有节点的值都是唯一的。
    p、q 为不同节点且均存在于给定的二叉树中。

     */
    public class LowestCommonAncestorForBT
    {
  
        Dictionary<int, TreeNode> dict = new Dictionary<int, TreeNode>();

        public TreeNode Solution(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            GetPath(root,root);
            dict[root.val] = null;
            int pValue = p.val;
            int qValue = q.val;
            int p_val = pValue;
            int q_val = pValue;
            while (dict[p_val] != null)
            {
                 q_val = qValue;
                while (dict[q_val] != null)
                {
                    if (dict[p_val].val == q_val)
                        return dict[p_val];
                    if (p_val == dict[q_val].val)
                        return dict[q_val];
                    if (dict[p_val] == dict[q_val])
                    return dict[p_val];
                
                    if (q_val != root.val)
                        q_val = dict[q_val].val;
                    else break;

                }
                if (p_val != root.val)
                    p_val = dict[p_val].val;
                else break;
            }

            while (dict[q_val] != null)
            {
                 p_val = pValue;
                while (dict[q_val] != null)
                {
                    if (dict[q_val].val == p_val)
                        return dict[q_val];
                    if (q_val == dict[p_val].val)
                        return dict[p_val];
                    if (dict[p_val] == dict[q_val])
                        return dict[p_val];
                   
                    if (p_val != root.val)
                        p_val = dict[p_val].val;
                    else break;

                }
                if (q_val != root.val)
                    q_val = dict[q_val].val;
                else break;
            }


            return root;
      

        }

        private void GetPath(TreeNode node,  TreeNode root)
        {
            if (node == null) return;
            dict[node.val] = root;
            GetPath(node.left,node);

            GetPath(node.right, node);

        }


    }
}
