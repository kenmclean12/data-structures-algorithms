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
        List<ListNode> nodeList = new();
        foreach (ListNode list in lists) {
            ListNode curr = list;
            while (curr != null) {
                nodeList.Add(curr);
                curr = curr.next;
            }
        }

        nodeList.Sort((a, b) => a.val.CompareTo(b.val));

        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        for (int i = 0; i < nodeList.Count; i++) {
            tail.next = nodeList[i];
            tail = tail.next;
        }

        return dummy.next;
    }
}
