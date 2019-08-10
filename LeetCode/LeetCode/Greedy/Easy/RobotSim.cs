using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy.Easy
{
    public class RobotSim
    {/*
        机器人在一个无限大小的网格上行走，从点 (0, 0) 处开始出发，面向北方。该机器人可以接收以下三种类型的命令：

        -2：向左转 90 度
        -1：向右转 90 度
        1 <= x <= 9：向前移动 x 个单位长度
        在网格上有一些格子被视为障碍物。

        第 i 个障碍物位于网格点  (obstacles[i][0], obstacles[i][1])

        如果机器人试图走到障碍物上方，那么它将停留在障碍物的前一个网格方块上，但仍然可以继续该路线的其余部分。

        返回从原点到机器人的最大欧式距离的平方。

 

        示例 1：

        输入: commands = [4,-1,3], obstacles = []
        输出: 25
        解释: 机器人将会到达 (3, 4)
        示例 2：

        输入: commands = [4,-1,4,-2,4], obstacles = [[2,4]]
        输出: 65
        解释: 机器人在左转走到 (1, 8) 之前将被困在 (1, 4) 处
 

        提示：

        0 <= commands.length <= 10000
        0 <= obstacles.length <= 10000
        -30000 <= obstacle[i][0] <= 30000
        -30000 <= obstacle[i][1] <= 30000
        答案保证小于 2 ^ 31


         */
        public int Solution(int[] commands, int[][] obstacles)
        {
            var n = commands.Length;
            var oriten = 0; //oriten: 0 向北， 1向东，2向南，3向西
            var step = 0;
            var x = 0;      //机器人当前横坐标
            var y = 0;      //机器人当前纵坐标
            var res = int.MinValue;
            var k = obstacles.Length;
            var set = new HashSet<Tuple<int,int>>();
            foreach (var item in obstacles)
            {
                set.Add(new Tuple<int, int>(item[0], item[1]));
            }

   

            for (int i = 0; i < n; i++)
            {
                step = 0;
                switch (commands[i])
                {
                    case -1:                    //向右转
                        oriten += 1;            
                        oriten = oriten % 4;    // 当oriten 大于3时，可以得到 0,1,2,3四个方向
                        break;
                    case -2:                    //向左转
                        oriten -= 1;
                        if (oriten < 0)             
                            oriten = 4 + oriten;    //当oriten被减到小于0时，+4即可得到对应的右转方向
                        oriten = oriten % 4;
                        break;
                    default:
                        
                        step += commands[i];        //移动，把移动步数赋值到step
                        break;
                }
                
                if (step != 0)
                {
                  
                    switch (oriten)
                    {
                        case 1: //向东走
                         
                            for (int j = 1; j <= step; j++) //如果当前指令是移动，每移动一步之前都要检查一下步有没有障碍
                            {
                                if (set.Contains(new Tuple<int, int> (x+j,y))) //如果存在当前纵坐标等于y，横坐标等于x+j的障碍
                                {
                                    step = j - 1;    //只能移动j-1步，覆盖step
                                    break;
                                }

                            }
                            x += step;             //机器人向东移动，如果上面检查没有障碍，则移动原来的step步，如果检查到障碍step已经被覆盖成j-1             
                            break;
                        case 0: //向北走
                            for (int j = 1; j <= step; j++)
                            {
                                var array = new int[] { 0, 1 };
                                if (set.Contains(new Tuple<int, int>(x, y+j)))
                                {
                                    step = j - 1;
                                    break;
                                }
                            }
                            y += step;
                            break;
                        case 2://向南走
                            for (int j = 1; j <= step; j++)
                            {
                                if (set.Contains(new Tuple<int, int>(x, y-j)))
                                {
                                    step = j - 1;
                                    break;
                                }
                            }
                            y -= step;
                            break;
                        case 3://向西走
                            for (int j = 1; j <= step; j++)
                            {
                                if (set.Contains(new Tuple<int, int>(x - j, y)))
                                {
                                    step = j - 1;
                                    break;
                                }
                            }
                            x -= step;
                            break;
                    }
                }
                res = Math.Max(res, x * x + y * y);
            }

            return res;
        }
    }
}
