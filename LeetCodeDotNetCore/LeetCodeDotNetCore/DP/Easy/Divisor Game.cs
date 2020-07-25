using System;
namespace LeetCodeDotNetCore.DP.Easy
{
    /*
     * 
     * Alice and Bob take turns playing a game, with Alice starting first.

        Initially, there is a number N on the chalkboard.  On each player's turn, that player makes a move consisting of:

        Choosing any x with 0 < x < N and N % x == 0.
        Replacing the number N on the chalkboard with N - x.
        Also, if a player cannot make a move, they lose the game.

        Return True if and only if Alice wins the game, assuming both players play optimally.


        Example 1:

        Input: 2
        Output: true
        Explanation: Alice chooses 1, and Bob has no more moves.
        Example 2:

        Input: 3
        Output: false
        Explanation: Alice chooses 1, Bob chooses 1, and Alice has no more moves.
 

        Note:

        1 <= N <= 1000

     */
    public class DivisorGame
    {
        public bool Solution(int N)
        {
            if (N == 1)
            {
                return false;
            }
            if (N == 2)
            {
                return true;
            }
            if (N == 3)
            {
                return false;
            }
            var cur = 0;    //0代表Alice先手
            while (N > 0)   
            {
                var flag = false;
                for (int i = 1; i < N; i++)     //从1开始到N遍历
                {
                    if (N % i == 0)             //如果N满足被i整除
                    {
                        flag = true;            //变flag
                        cur = cur == 0 ? 1 : 0; //换人来进行下一轮
                        N = N - i;              //N变成N-i
                        break;                  //break掉本轮循环，进入下一轮
                    }
                }
                if (!flag)                      //如果本轮循环中从1到N-1没有一个数满足N % i == 0，while循环break掉
                {
                    break;
                }
            }
            //此时肯定是满足从1到N-1没有一个数满足N % i == 0，只需要根据当前的player来返回true和false
            if (cur == 1)
            {
                return true;
            }
            return false;
        }
    }
}
