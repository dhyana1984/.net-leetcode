using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*报数序列是一个整数序列，按照其中的整数的顺序进行报数，得到下一个数。其前五项如下：

    1.     1
    2.     11
    3.     21
    4.     1211
    5.     111221
    */
    public class SolutionCountAndSay
    {
        public string Solution(int n)
        {
            string strCur = n == 1 ? "1" : "11";
            StringBuilder strTemp = new StringBuilder(); 

            if (n>2)
            {
                for (int i = 2; i < n; i++)
                {
                    int count = 1;
                    strTemp.Clear();
                    for (int j = 0; j < strCur.Length; j++)
                    {
                        if (j < strCur.Length - 1)
                        {
                            if (strCur[j] == strCur[j + 1])
                            {
                                count++;
                            }
                            else
                            {
                                strTemp.Append(count.ToString());
                                strTemp.Append(strCur[j].ToString());
                                count = 1;
                            }
                        }
                        else
                        {
                            strTemp.Append(count.ToString());
                            strTemp.Append(strCur[j].ToString());

                        }
                        
                    }
                    strCur = strTemp.ToString();
                }
            }

            return strCur;
            
            //List<int[]> list = new List<int[]>();
            //Dictionary<string, int> dict = new Dictionary<string, int>();
            //dict["1"] = 1;
            //list.Add(new int[] { 1 });
            //for (int i = 1; i < n; i++)
            //{

            //}
        }
    }
}
