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
        List<ListNode> allNodes = new List<ListNode>();
        foreach(var list in lists) {
            ListNode curr = list;
            while (curr != null) {
                allNodes.Add(curr);
                curr = curr.next;
            }
        }

        allNodes.Sort((a, b) => a.val.CompareTo(b.val));

        ListNode dummy = new ListNode();
        ListNode tail = dummy;

        for (int i = 0; i < allNodes.Count; i++) {
            tail.next = allNodes[i];
            tail = tail.next;
        }

        return dummy.next;
    }
}
