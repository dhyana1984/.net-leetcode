using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 给定一个 N 叉树，返回其节点值的前序遍历。
     */
    public class N_aryTreePreorderTraversal
    {
        public IList<int> Solution(Node root)
        {

            IList<int> resultList = new List<int>();
            PreOrder(root, resultList);
            return resultList;

        }

        private void PreOrder(Node root, IList<int> resultList)
        {
            if (root == null) return;
            resultList.Add(root.val);

            if (root.children != null)
                for (int i = 0; i < root.children.Count; i++)
                {
                    PreOrder(root.children[i], resultList);
                }


        }
    }
}
