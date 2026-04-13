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
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        while (head != null) {
           int count = 0;
           ListNode check = head;

           while (count < k && check != null) {
              count++;
              check = check.next;
           }

           if (count < k) {
             tail.next = head;
             break;
           }

           ListNode prev = null;
           ListNode curr = head;

           for (int i = 0; i < k; i++) {
              var tmp = curr.next;
              curr.next = prev;
              prev = curr;
              curr = tmp;
           }

           tail.next = prev;
           tail = head;
           head = curr;
        }

        return dummy.next;
    }
}
