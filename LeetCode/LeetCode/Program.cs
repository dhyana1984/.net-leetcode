using LeetCode.Easy;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Medium.SolutionAddTwoNumbers;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //SolutionAddTwoNumbers solution = new SolutionAddTwoNumbers();
            //ListNode l1 = new ListNode(2);
            //ListNode l2 = new ListNode(4);
            //ListNode l3 = new ListNode(3);
            //ListNode l4 = new ListNode(5);
            //ListNode l5= new ListNode(6);
            //ListNode l6 = new ListNode(4);
            //l1.next = l2;l2.next = l3;
            //l4.next = l5;l5.next = l6;
            //solution.AddTwoNumbers(l1,l4);

            SolutionRemoveElement solution = new SolutionRemoveElement();
            int[] b = {2,2,2,1,2,2,2,2,2,1,2,1,2,2,1,2,1,2,1,1,1 };
            int a = solution.RemoveElement(b,2);
            /// solution.LongestCommonPrefix(new string[] { "a", "a","b"});
            /// 

        }
    }
}
