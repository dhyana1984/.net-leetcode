using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
   public class DeleteListDuplicates
    {
        public ListNode Solution(ListNode head)
        {
            ListNode result = head;
            while (result != null && result.next != null)
            {
                if (result.val == result.next.val)
                    result.next = result.next.next;
                else
                    result = result.next;
            }

            return head;
        }
    }





}
