using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack.Medium
{

    public class AsteroidCollision
    {
        /*
         * 给定一个整数数组 asteroids，表示在同一行的行星。

        对于数组中的每一个元素，其绝对值表示行星的大小，正负表示行星的移动方向（正表示向右移动，负表示向左移动）。每一颗行星以相同的速度移动。

        找出碰撞后剩下的所有行星。碰撞规则：两个行星相互碰撞，较小的行星会爆炸。如果两颗行星大小相同，则两颗行星都会爆炸。两颗移动方向相同的行星，永远不会发生碰撞。

        示例 1:

        输入: 
        asteroids = [5, 10, -5]
        输出: [5, 10]
        解释: 
        10 和 -5 碰撞后只剩下 10。 5 和 10 永远不会发生碰撞。
        示例 2:

        输入: 
        asteroids = [8, -8]
        输出: []
        解释: 
        8 和 -8 碰撞后，两者都发生爆炸。
        示例 3:

        输入: 
        asteroids = [10, 2, -5]
        输出: [10]
        解释: 
        2 和 -5 发生碰撞后剩下 -5。10 和 -5 发生碰撞后剩下 10。
        示例 4:

        输入: 
        asteroids = [-2, -1, 1, 2]
        输出: [-2, -1, 1, 2]
        解释: 
        -2 和 -1 向左移动，而 1 和 2 向右移动。
        由于移动方向相同的行星不会发生碰撞，所以最终没有行星发生碰撞。
        说明:

        数组 asteroids 的长度不超过 10000。
        每一颗行星的大小都是非零整数，范围是 [-1000, 1000] 。

         */
        public int[] Solution(int[] asteroids)
        {
            var stack = new Stack<int>();
            var res = new List<int>();


            for (var i = 0; i < asteroids.Length; i++)
            {
                var pop = 1001; //用于判断绝对值相等的两个数
                while (stack.Any() && asteroids[stack.Peek()] > 0 && asteroids[i] < 0)//如果可能发生碰撞
                {
                    if (Math.Abs(asteroids[stack.Peek()]) < Math.Abs(asteroids[i])) //右边的绝对值比左边大
                        stack.Pop();            //左边被撞碎
                    else if (Math.Abs(asteroids[stack.Peek()]) == Math.Abs(asteroids[i]))//左右一样大
                    {
                        pop = stack.Pop();//左边撞碎并且记录大小
                        break;            //不再继续撞
                    }
                    else
                        break;           //右边比左边小，右边直接撞碎（此情况下不应该进栈）

                }
                if (!stack.Any() && pop == 1001) //空栈，并且肯定是右边大
                    stack.Push(i);
                else if (stack.Any() && asteroids[stack.Peek()] * asteroids[i] > 0 && pop == 1001)//左右方向相同
                    stack.Push(i);
                else if (stack.Any() && asteroids[stack.Peek()] * asteroids[i] < 0 && asteroids[i] > 0 && pop == 1001)//左右方向不同且左边向左，右边向右
                    stack.Push(i);

            }

            while (stack.Any())
            {
                res.Insert(0, asteroids[stack.Pop()]);
            }
            return res.ToArray();
        }
    }
}
