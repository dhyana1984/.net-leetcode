using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 给定一个整数 n，生成所有由 1 ... n 为节点所组成的二叉搜索树。

        示例:

        输入: 3
        输出:
        [
          [1,null,3,2],
          [3,2,null,1],
          [3,1,null,null,2],
          [2,1,3],
          [1,null,2,null,3]
        ]
        解释:
        以上的输出对应以下 5 种不同结构的二叉搜索树：

           1         3     3      2      1
            \       /     /      / \      \
             3     2     1      1   3      2
            /     /       \                 \
           2     1         2                 3


         
             * 依据一个有序的排列，来构造出所有可能的二叉搜索树
             * 思路：
             *  1.考虑将一个大问题，逐渐分解为一个小问题-->递归的思路
             *  2.对于每个子问题，考虑的事情都是：谁要作为根，谁要作为左子树，谁要作为右子树
             *  3.当一个子问题仅有根，而没有子树的时候，就说明当前讨论的是叶子了
             *  
             * 时间复杂度：O(n!),每个序列元素都可以作为根存在，那么第一层的可能性有n种，第二层的可能性有n-1种，依次类推，毕竟要遍历出所有的可能性
             * 空间复杂度：O(n!),要将所有的可能性存储起来
             * 这种复杂度会急剧增加的算法，输入的n不宜太大，或者说，可以考虑使用并行运算
             * 
             * 考察点：
             *  1.回溯法
             *  2.对搜索二叉树的理解
             

     */
    public class GenerateBST
    {
        public IList<TreeNode> Solution(int n)
        {
            if (n == 0)
                return new List<TreeNode>();


            return GenerateTree(1, n);



        }

        private List<TreeNode> GenerateTree(int start, int end)
        {
            var res = new List<TreeNode>();
            if (start > end)
            {
                res.Add(null);
                return res;
            }

            for (int i = start; i <= end; i++)
            {
                List<TreeNode> subLeftTree = GenerateTree(start, i - 1);
                List<TreeNode> subRightTree = GenerateTree(i + 1, end);
                foreach (var left in subLeftTree)
                    foreach (var right in subRightTree)
                    {
                        var node = new TreeNode(i);
                        node.left = left;
                        node.right = right;
                        res.Add(node);
                    }
            }
            return res;



        }



    }
}
