using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy.Easy
{
    /*
     * 公司计划面试 2N 人。第 i 人飞往 A 市的费用为 costs[i][0]，飞往 B 市的费用为 costs[i][1]。

        返回将每个人都飞到某座城市的最低费用，要求每个城市都有 N 人抵达。

 

        示例：

        输入：[[10,20],[30,200],[400,50],[30,20]]
        输出：110
        解释：
        第一个人去 A 市，费用为 10。
        第二个人去 A 市，费用为 30。
        第三个人去 B 市，费用为 50。
        第四个人去 B 市，费用为 20。

        最低总费用为 10 + 30 + 50 + 20 = 110，每个城市都有一半的人在面试。
 

        提示：

        1 <= costs.length <= 100
        costs.length 为偶数
        1 <= costs[i][0], costs[i][1] <= 1000

     */

    public class TwoCitySchedCost
    {
        public int Solution(int[][] costs)
        {
            var list = new List<int[]>();
            var res = 0;
            for (var i = 0; i < costs.Length; i++)
            {
                var diff = costs[i][0] - costs[i][1];   //得到飞往A地和飞往B地的差值
                if (list.Count < costs.Length / 2)      //前N/2个人直接把差值存到list
                {
                    var array = new int[3];
                    array[0] = i;                       //存costs的索引
                    array[1] = diff;                    //存差值
                    array[2] = costs[i][0];             //存飞往A地的花费
                    list.Add(array);
                    res += costs[i][0];                 //加上飞往A地花费
                }
                else if (diff < list.Max(t => t[1]))    //当从N/2 +1 个人起，有人的差值比已存差值更小时
                {
                    var array = new int[3];             //和上面一样存
                    array[0] = i;
                    array[1] = diff;
                    array[2] = costs[i][0];
                    var maxIndex = list.FindIndex(t => t[1] == list.Max(p => p[1]));//获得list里面最大的diff的索引
                    res -= list[maxIndex][2];               //减去已经加到res的飞往A地费用
                    res += costs[list[maxIndex][0]][1];     //加上costs的该索引的飞往B地费用
                    list.RemoveAt(maxIndex);                //list里面去掉该diff
                    list.Add(array);                        //list加上新的diff
                    res += costs[i][0];                     //res加上新的飞往A地费用
                }
                else
                    res += costs[i][1];                     //什么条件都不满足，res加上飞往B地费用

            }
            return res;


        }
    }
}
