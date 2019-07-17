using LeetCode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium.Tree
{
    /*
     * 给定二叉树，按垂序遍历返回其结点值。

        对位于 (X, Y) 的每个结点而言，其左右子结点分别位于 (X-1, Y-1) 和 (X+1, Y-1)。

        把一条垂线从 X = -infinity 移动到 X = +infinity ，每当该垂线与结点接触时，我们按从上到下的顺序报告结点的值（ Y 坐标递减）。

        如果两个结点位置相同，则首先报告的结点值较小。

        按 X 坐标顺序返回非空报告的列表。每个报告都有一个结点值列表。
        输入：[3,9,20,null,null,15,7]
        输出：[[9],[3,15],[20],[7]]
        解释： 
        在不丧失其普遍性的情况下，我们可以假设根结点位于 (0, 0)：
        然后，值为 9 的结点出现在 (-1, -1)；
        值为 3 和 15 的两个结点分别出现在 (0, 0) 和 (0, -2)；
        值为 20 的结点出现在 (1, -1)；
        值为 7 的结点出现在 (2, -2)。

        输入：[1,2,3,4,5,6,7]
        输出：[[4],[2],[1,5,6],[3],[7]]
        解释：
        根据给定的方案，值为 5 和 6 的两个结点出现在同一位置。
        然而，在报告 "[1,5,6]" 中，结点值 5 排在前面，因为 5 小于 6。


     */


    public class VerticalTraversal
    {
        Dictionary<TreeNode, int[]> dict = new Dictionary<TreeNode, int[]>();
        public IList<IList<int>> Solution(TreeNode root)
        {

            FindCoordinate(root, root);
            var min_X = dict.Values.Min<int[]>(t => t[0]);  //x轴最小值，即字典值数组index=0的最小值
            var max_X = dict.Values.Max<int[]>(t => t[0]);  //x轴最大值，即字典值数组index=0最大值

            var min_Y = dict.Values.Min<int[]>(t => t[1]);  //y轴根节点0最大，最小是字典值数组index=1最小值
            var res = new List<IList<int>>();
            for (var i = min_X; i <= max_X; i++)            //遍历坐标系x轴
            {
                var list = new List<int>();
                for (var j = 0; j >= min_Y; j--)            //遍历坐标系y轴
                {
                    var coordinate = new int[2] { i, j };   //当前坐标
                    dict.Where(t => Enumerable.SequenceEqual(t.Value, coordinate))  //如果有节点的坐标是当前坐标
                        .ToList()
                        .OrderBy(t => t.Key.val)                                      //排序
                        .ToList()
                        .ForEach(x => list.Add(x.Key.val));                          //保存到结果

                }
                res.Add(list);
            }
            return res;


        }

        //遍历树，计算每个节点坐标
        private void FindCoordinate(TreeNode node, TreeNode root)
        {
            if (node == null)
                return;
            var coordinate = new int[2];    //用一个数组保存坐标,index=0是x轴，index=1是y轴
            if (node == root.right)
            {
                coordinate[0] = dict[root][0] + 1; //右节点x轴比父节点+1
                coordinate[1] = dict[root][1] - 1; //y轴始终比父节点-1
            }
            else if (node == root.left)
            {
                coordinate[0] = dict[root][0] - 1;//左节点x轴比父节点-1
                coordinate[1] = dict[root][1] - 1;//y轴始终比父节点-1
            }
            dict[node] = coordinate;             //用节点作为Key,坐标作为Value
            //先序遍历
            FindCoordinate(node.left, node);
            FindCoordinate(node.right, node);
        }
    }

}
