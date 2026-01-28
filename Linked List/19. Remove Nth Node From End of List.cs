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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
            if (head.next == null && n >= 1)
                return null;

            // Find the length of the list
            int length = 0;
            var itr = head;
            while (itr != null)
            {
                length++;
                itr = itr.next;
            }
            int k = length - n + 1;

            if (n == length)
                return head.next;

            var xHead = head;
            var prev = head;
            int idx = 1;
            while (idx != k)
            {
                prev = xHead;
                idx++;
                xHead = xHead.next;
            }
            prev.next = xHead.next;

            return head;
    }
}