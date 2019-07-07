using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定二叉搜索树（BST）的根节点和要插入树中的值，将值插入二叉搜索树。 返回插入后二叉搜索树的根节点。 保证原始二叉搜索树中不存在新值。

注意，可能存在多种有效的插入方式，只要树在插入后仍保持为二叉搜索树即可。 你可以返回任意有效的结果。

例如, 

给定二叉搜索树:

        4
       / \
      2   7
     / \
    1   3

和 插入的值: 5
你可以返回这个二叉搜索树:

         4
       /   \
      2     7
     / \   /
    1   3 5
或者这个树也是有效的:

         5
       /   \
      2     7
     / \   
    1   3
         \
          4

     */

    public class InsertIntoBST
    {

        List<int> list = new List<int>();
        public TreeNode Solution(TreeNode root, int val)
        {
            InsertNode(root);
            TreeNode theRoot = null;
            TreeNode curr = null;
    
            for (int i = 0; i < list.Count; i++)
            {


                if (i == 0)
                {

                    if (val < list[i])
                    {
                        theRoot = new TreeNode(val);
                        theRoot.right = new TreeNode(list[i]);
                        curr = theRoot.right;
                    }
                    else
                    {
                        theRoot = new TreeNode(list[i]);
                        curr = theRoot;
                    }


                }
                else if (i == list.Count - 1)
                {
                    if (val > list[i])
                    {
                        curr.right = new TreeNode(list[i]);
                        curr.right.right = new TreeNode(val);
                    }
                    else
                        curr.right = new TreeNode(list[i]);

                }
                else if (i > 0 && i < list.Count - 1)
                {

                    curr.right = new TreeNode(list[i]);
                    curr = curr.right;
                    if (list[i] < val && list[i + 1] > val)
                    {
                        curr.right = new TreeNode(val);

                        curr = curr.right;
                    }
                }
            }
            return theRoot;
        }

        private void InsertNode(TreeNode node)
        {
            if (node == null)
                return;
            InsertNode(node.left);
            list.Add(node.val);
            InsertNode(node.right);


        }
    }
}
