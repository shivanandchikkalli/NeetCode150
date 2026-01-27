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
    public void ReorderList(ListNode head) {
        if (head is null || head.next is null)
            return;

        var slow = head;
        var fast = head.next;

        // find the second half of the list
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // slow will be the end of the first half

        // reverse the second half of the list
        var prev = slow.next;      // beginning of second half  
        var next = prev.next;      // second node of second half
        prev.next = null;          // end of second half
        slow.next = null;         // end of first half

        while (next != null)
        {
            var curr = next;
            next = next.next;
            curr.next = prev;
            prev = curr;
        }
        var second = prev;

        // reording now
        while (head != null && second != null)
        {
            var temp1 = head.next;
            var temp2 = second.next;
            head.next = second;
            second.next = temp1;
            head = temp1;
            second = temp2;
        }       
    }
}