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
        var mergedList = new List<int>();

        var curr1 = list1;
        while (curr1 != null) {
            mergedList.Add(curr1.val);
            curr1 = curr1.next;
        }

        var curr2 = list2;
        while (curr2 != null) {
            mergedList.Add(curr2.val);
            curr2 = curr2.next;
        }

        mergedList.Sort();

        var dummy = new ListNode(0);
        var tail = dummy;

        for (int i = 0; i < mergedList.Count; i++) {
            tail.next = new ListNode(mergedList[i]);
            tail = tail.next;
        }

        return dummy.next;
    }
}