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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode start = null;
        ListNode current = null;

        if (list1 is null) return list2;
        else if (list2 is null) return list1;        

        if (list1.val <= list2.val)
        {
            current = list1;
            list1 = list1.next;
        }
        else
        {
            current = list2;
            list2 = list2.next;
        }
        start = current;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                current = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                current = list2;
                list2 = list2.next;
            }
        }

        if (list1 == null)
            current.next = list2;
        else
            current.next = list1;

        return start;
    }
}