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
            //ListNode head = new ListNode(1);
            //head.next = new ListNode(1);
            //head.next.next = new ListNode(2);
            //head.next.next.next = new ListNode(3);
            //head.next.next.next.next = new ListNode(3);
            MergeSortedArray solution = new MergeSortedArray();
            solution.Solution(new int[] { 4, 5, 6, 0, 0, 0 },3,new int[] { 1, 2, 3 },3);
        }
    }
}
