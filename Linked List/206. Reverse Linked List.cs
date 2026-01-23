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
    public ListNode ReverseList(ListNode head) {
        if (head is null || head.next is null)
            return head;
        ListNode previous = head;
        ListNode current = head.next;
        previous.next = null;

        while (current != null)
        {
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }
        return previous;
    }
}