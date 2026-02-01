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
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists is null || lists.Length == 0)
            return null;

        while (lists.Length > 1)
        {
            var mergedLists = new List<ListNode>();
            for (int i = 0; i < lists.Length; i += 2)
            {
                ListNode? first = lists[i];
                ListNode? second = (i + 1) < lists.Length ? lists[i + 1] : null;
                mergedLists.Add(mergeSortedLists(first, second));
            }
            lists = mergedLists.ToArray();
        }

        ListNode mergeSortedLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            var current = dummy;

            while (l1 is not null && l2 is not null)
            {
                if (l1.val <= l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }
            if (l1 is null)
                current.next = l2;
            else
                current.next = l1;

            return dummy.next;
        }

        return lists[0];
    }
}