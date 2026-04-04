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
    public ListNode ReverseList(ListNode head) {
        var arr = new List<int>();
        var curr = head;

        while (curr != null) {
            arr.Add(curr.val);
            curr = curr.next;
        }

        arr.Reverse();

        var dummy = new ListNode(0);
        var tail = dummy;

        for (int i = 0; i < arr.Count; i++) {
            tail.next = new ListNode(arr[i]);
            tail = tail.next;
        }

        return dummy.next;
    }
}
