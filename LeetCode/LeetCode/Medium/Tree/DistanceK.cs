using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定一个二叉树（具有根结点 root）， 一个目标结点 target ，和一个整数值 K 。

            返回到目标结点 target 距离为 K 的所有结点的值的列表。 答案可以以任何顺序返回。

 

            示例 1：

            输入：root = [3,5,1,6,2,0,8,null,null,7,4], target = 5, K = 2

            输出：[7,4,1]

            解释：
            所求结点为与目标结点（值为 5）距离为 2 的结点，
            值分别为 7，4，以及 1


。
     */


    public class DistanceK
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            public IList<int> Solution(TreeNode root, TreeNode target, int K)
            {

                List<int> ret = new List<int>();
                dfs(root, target);
                find(ret, root, K, dict[root.val]);
                return ret;
            }


            //先dfs遍历树找到target节点, 同时标记由root节点到target节点路径上所有节点到target的距离
            private int dfs(TreeNode r, TreeNode tar)
            {
                if (r == null)
                    return -1;
                if (r == tar)
                {
                    dict[tar.val] = 0;
                    return 0;
                }

                int left = dfs(r.left, tar);
                int right = dfs(r.right, tar);
                if (left != -1)
                {
                    dict[r.val] = left + 1;
                    return left + 1;
                }
                if (right != -1)
                {
                    dict[r.val] = right + 1;
                    return right + 1;
                }
                return -1;
            }
        //随后再从root开始对整个树进行dfs搜索(初始距离为map中保存的root到target的距离), , 
            private void find(List<int> ret, TreeNode r, int K, int d)
            {
                if (r == null)
                    return;
                //对于任意一个访问到的节点, 如果在map内已有该节点, 取map内该节点到target的距离并判断是否为k
                if (dict.ContainsKey(r.val))
                    d = dict[r.val];
                if (d == K)
                    ret.Add(r.val);
            //如果不在map内, 依次访问左右子节点, 并将距离加1
                find(ret, r.left, K, d + 1);
                find(ret, r.right, K, d + 1);
            }
        }
    }
