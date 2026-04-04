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
        var allNodes = new List<ListNode>();
        foreach(var list in lists) {
            var curr = list;
            while (curr != null) {
                allNodes.Add(curr);
                curr = curr.next;
            }
        }

        allNodes.Sort((a, b) => a.val - b.val);

        var dummy = new ListNode();
        var tail = dummy;

        for (int i = 0; i < allNodes.Count(); i++) {
            tail.next = allNodes[i];
            tail = tail.next;
        }

        tail.next = null;

        return dummy.next;
    }
}
