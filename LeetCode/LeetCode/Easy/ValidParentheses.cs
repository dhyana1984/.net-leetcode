using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
  public  class SolutionValidParentheses
    {
        public bool IsValidParentheses(string s)
        {

            if (s.Trim() == "")
                return true;
            if (s.Length%2 != 0)
                return false;
            s = s.Trim();
            string s1 = s.Substring(0, s.Length / 2);
            string s2 = s.Substring(s.Length / 2,s.Length/2);
            if (s1 == new string(s2.Reverse().ToArray()))
                return true;
            return false;
        }
    }
}

