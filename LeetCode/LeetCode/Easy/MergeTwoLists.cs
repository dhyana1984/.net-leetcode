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

            Dictionary<int, int> dict = new Dictionary<int, int>();
            int index = 2;
            if (l1.val <= l2.val)
            {
                dict[0] = l1.val;
                dict[1] = l2.val;
            }
            else
            {
                dict[0] = l2.val;
                dict[1] = l1.val;
            }

            while(l1.next != null)
            {
                while (l2.next != null)
                {
                    if (l1.val <= l2.val)
                    {
                        dict[index] = l1.val;
                        dict[index + 1] = l2.val;
                    }
                    else
                    {
                        dict[index] = l2.val;
                        dict[index + 1] = l1.val;
                    }
                }
            }

            ListNode resultNode = new ListNode(dict[0]);
            if (dict.Count > 1)
            {
                resultNode.next = new ListNode(dict[1]);
                for (int i = 1; i < dict.Count; i++)
                {
                    ListNode node = new ListNode(dict[i]);
                    if (i < dict.Count-1)
                        node.next = new ListNode(dict[i + 1]);
                }
            }
            return resultNode;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
