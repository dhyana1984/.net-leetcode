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
            string strl1 = l1.val.ToString();
            string strl2 = l2.val.ToString();
            while (l1.next != null)
            {
                l1 = l1.next;
                strl1 = l1.val.ToString() + strl1;
                
            }
            while (l2.next != null)
            {
                l2 = l2.next;
                strl2 = l2.val.ToString()+strl2;
                
            }
            int int1 = Convert.ToInt16(strl1);
            int int2 = Convert.ToInt16(strl2);
            string strResult = (int1 + int2).ToString();
            ListNode resultNode = new ListNode(0);
            int length = strResult.Length - 1;
            for (int i = length; i>=0; i--)
            {
                int next = Convert.ToInt16(strResult[i - 1].ToString());
                int curr = Convert.ToInt16(strResult[i].ToString());
                if (i > 0)
                {
                    resultNode.next = new ListNode(curr);
                }
                resultNode.val = curr;

            }

            return resultNode;



        }
        public class ListNode
        {
            public int val;
            public ListNode next = null;
            public ListNode(int x) { val = x; }
        }
    }
}
