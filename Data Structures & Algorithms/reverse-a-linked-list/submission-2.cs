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
       var list = new List<int>();
       var curr = head;

       while (curr != null) {
        list.Add(curr.val);
        curr = curr.next;
       }

       list.Reverse();

       var dummy = new ListNode();
       var tail = dummy;

       for (int i = 0; i < list.Count; i++) {
         tail.next = new ListNode(list[i]);
         tail = tail.next;
       }

       return dummy.next;
    }
}
