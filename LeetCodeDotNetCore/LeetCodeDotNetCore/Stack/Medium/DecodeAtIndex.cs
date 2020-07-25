using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stack.Medium
{
   
    public class DecodeAtIndex
    {
        public string Solution(string S, int K)
        {
            ////暴力法
            //if (K == 1)
            //    return S[0].ToString();
            //if (K <= S.Length)
            //    return S[K - 1].ToString();
            //var result =new StringBuilder();
            //var tempStr = new StringBuilder();
            //var length = 0;
            //for (var i = 0; i < S.Length; i++)
            //{

            //    if (97 <= S[i] && S[i] <= 122)
            //    {
            //        tempStr.Append(S[i].ToString());
            //    }

            //    else
            //    {
            //        result.Append(tempStr);
            //        if (K <= result.Length)
            //            return result[K - 1].ToString();
            //        length = int.Parse(S[i].ToString());
            //        for (var j = 0; j < length - 1; j++)
            //        {
            //            result.Append(result);
            //            if (K <= result.Length)
            //                return result[K - 1].ToString();
            //        }
            //        tempStr.Clear();
            //    }
            //}
            //return result[K - 1].ToString();

            long size = 0;
            long k = (long)K;
            int N = S.Length;
            for (int i = 0; i < N; i++)
            {
                if (char.IsDigit(S[i]))
                {
                    size *= S[i] - '0';
                }
                else
                    size++;
            }
            


            for (int i = N-1; i >=0; i--)
            {
                //一般来说，当解码的字符串等于某个长度为 size 的单词重复某些次数
                //（例如 apple 与 size=5 组合重复6次）时，索引 K 的答案与索引 K % size 的答案相同。

                //每当解码的字符串等于某些单词 word 重复 d 次时，我们就可以将 k 减少到 K % (Word.Length)
                k %= size;
                if (k == 0 && !char.IsDigit(S[i]))
                    return "" + S[i];

                if (char.IsDigit(S[i]))
                    size /= S[i] - '0';
                else
                    size--;

            }
            return "";
        }
    }
}
