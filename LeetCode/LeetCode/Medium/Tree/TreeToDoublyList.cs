using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Medium.Tree.NodesModel;

namespace LeetCode.Medium.Tree
{
    /*
     * 将一个二叉搜索树就地转化为一个已排序的双向循环链表。可以将左右孩子指针作为双向循环链表的前驱和后继指针。
     */




    public class TreeToDoublyList
    {
        //List<LinkNode> list = new List<LinkNode>();
        LinkNode pre = null;
        public LinkNode Solution(LinkNode root)
        {
            if (root == null)
                return root;
            LinkNode dummy = new LinkNode(0, null, null);
            pre = dummy;
            InOrder(root);
            pre = dummy;
            InOrder(root);
            pre.right = dummy.right;
            dummy.right.left = pre;
            return dummy.right;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (i != list.Count - 1)
            //        list[i].right = list[i + 1];
            //    else
            //    {
            //        list[i].right = list[0];
            //    }
            //    if (i != 0)
            //        list[i].left = list[i - 1];
            //    else
            //        list[i].left = list[list.Count - 1];
            //}


            //InOrder(node.right);
            //return list[0];

        }


        private void InOrder(LinkNode node)
        {
            if (node == null)
                return;
            InOrder(node.left);
            //list.Add(node);
            pre.right = node;
            node.left = pre;
            pre = node;
            InOrder(node.right);
        }
    }
}
