using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 将两个有序链表合并为一个新的有序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 

        示例：

        输入：1->2->4, 1->3->4
        输出：1->1->2->3->4->4
     */
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
