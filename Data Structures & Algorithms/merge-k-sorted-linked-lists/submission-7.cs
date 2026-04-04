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
        var allNumbers = new List<int>();
        foreach(var list in lists) {
            var curr = list;
            while (curr != null) {
                allNumbers.Add(curr.val);
                curr = curr.next;
            }
        }

        allNumbers.Sort();

        var dummy = new ListNode();
        var tail = dummy;

        foreach(int n in allNumbers) {
            tail.next = new ListNode(n);
            tail = tail.next;
        }

        return dummy.next;
    }
}
