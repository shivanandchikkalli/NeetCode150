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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode newList = null;
        ListNode prevNode = null;

        int carry = 0;
        while (l1 is not null || l2 is not null)
        { 
            int sum = (l1 is null ? 0 : l1.val) + (l2 is null ? 0 : l2.val) + carry;
            int num = sum % 10;
            carry = sum / 10;

            var newNode = new ListNode(num);
            if (prevNode is null)
            {
                prevNode = newNode;
                newList = prevNode;
            }
            else
            { 
                prevNode.next = newNode;
                prevNode = newNode;
            }

            if(l1 is not null)
                l1 = l1.next;
            
            if(l2 is not null)
                l2 = l2.next;
        }
        if (carry != 0)
        {
            var newNode = new ListNode(carry);
            prevNode.next = newNode;
        }

        return newList;
    }
}