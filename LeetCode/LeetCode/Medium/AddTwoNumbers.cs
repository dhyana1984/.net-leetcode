using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
   public class SolutionAddTwoNumbers
    {
        /*
          给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。
          如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。
          您可以假设除了数字 0 之外，这两个数都不会以 0 开头。
          示例：
            输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
            输出：7 -> 0 -> 8
            原因：342 + 465 = 807
        */

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode DumyHead = new ListNode(0);
            ListNode curNode = DumyHead;
            ListNode p = l1, q = l2;
            int carry = 0;//进位
            while (p != null || q != null)
            {
                int x = p != null ? p.val : 0;
                int y = q != null ? q.val : 0;
                int sum = x + y + carry;
                carry = sum / 10;
                curNode.next = new ListNode(sum % 10);
                curNode = curNode.next;
                p = p != null ? p.next : p;
                q = q != null ? q.next : q;
            }
            if (carry > 0)
                curNode.next = new ListNode(carry);
            return DumyHead.next;

  



        }
        public class ListNode
        {
            public int val;
            public ListNode next = null;
            public ListNode(int x) { val = x; }
        }
    }
}
