using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class SolutionMergeTwoLists
    {

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode r = result;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    r.next = new ListNode(l1.val);
                    l1 = l1.next;
                }
                else
                {
                    r.next = new ListNode(l2.val);
                    l2 = l2.next;
                }
                r = r.next;
            }
            if (l1 == null)
            {
                r.next = l2;
            }
            else
            {
                r.next = l1;
            }
            return result.next;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
