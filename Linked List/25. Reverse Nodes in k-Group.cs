/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        // Split the 
        ListNode resultHead = head;
        var prevHead = head;
        ListNode prevLast = null;
        ListNode current = head;
        int index = 0;
        while (index < k && current is not null)
        { 
            current = current.next;
            index++;

            if (index == k)
            {
                (var start, var end) = reverseList(prevHead, current);

                if (prevLast is null)
                {
                    prevLast = end;
                    resultHead = start;
                }
                else
                {
                    prevLast.next = start;
                    prevLast = end;
                }

                index = 0;
                prevHead = current;
            }
        }

        prevLast.next = prevHead;

        return resultHead;

        (ListNode start, ListNode end) reverseList(ListNode list, ListNode endNode)
        {
            var prev = list;
            var current = list.next;

            while (current != endNode)
            {
                var temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }

            return (prev, list);
        }
    }  
}