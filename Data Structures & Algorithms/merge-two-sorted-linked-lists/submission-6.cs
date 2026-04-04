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
        var merged = new List<ListNode>();

        var curr1 = list1;
        while (curr1 != null) {
            merged.Add(curr1);
            curr1 = curr1.next;
        }

        var curr2 = list2;
        while (curr2 != null) {
            merged.Add(curr2);
            curr2 = curr2.next;
        }

        merged.Sort((a, b) => a.val.CompareTo(b.val));

        var dummy = new ListNode();
        var tail = dummy;

        for (int i = 0; i < merged.Count; i++) {
            tail.next = merged[i];
            tail = tail.next;
        }

        return dummy.next;
    }
}