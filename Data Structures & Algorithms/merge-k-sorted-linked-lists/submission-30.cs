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
    public ListNode MergeKLists(ListNode[] lists) {
        List<int> allLists = [];
        foreach (ListNode list in lists) {
            ListNode current = list;
            while (current != null) {
                allLists.Add(current.val);
                current = current.next;
            }
        }

        allLists.Sort((a, b) => a.CompareTo(b));

        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;

        foreach (int val in allLists) {
            curr.next = new ListNode(val);
            curr = curr.next;
        }

        return dummy.next;
    }
}
