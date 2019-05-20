using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 给定一个有相同值的二叉搜索树（BST），找出 BST 中的所有众数（出现频率最高的元素）。

        假定 BST 有如下定义：

        结点左子树中所含结点的值小于等于当前结点的值
        结点右子树中所含结点的值大于等于当前结点的值
        左子树和右子树都是二叉搜索树
        例如：
        给定 BST [1,null,2,2],

           1
            \
             2
            /
           2
        返回[2].

        提示：如果众数超过1个，不需考虑输出顺序

        进阶：你可以不使用额外的空间吗？（假设由递归产生的隐式调用栈的开销不被计算在内）
     */
    public class BinTreeFindMode
    {
        public int[] Solution (TreeNode root)
        {
            if (root == null)
                return new int[0];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict[root.val] = dict.ContainsKey(root.val) ? dict[root.val] + 1 : 1;
            FindNode(root, dict);
            return dict.Keys.Where(t => dict[t] == dict.Values.Max()).ToArray();
        }


        private int FindNode(TreeNode node, Dictionary<int, int> dict)
        {
            if (node == null) return 0;
        
            if (node.left != null)
            {
                int left = FindNode(node.left, dict);
                dict[left] = dict.ContainsKey(left) ? dict[left] + 1 : 1;
            }
            if (node.right != null)
            {
                int right = FindNode(node.right, dict);
                dict[right] = dict.ContainsKey(right) ? dict[right] + 1 : 1;
            }
            return node.val;


        }


    }
}
