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
    public void ReorderList(ListNode head) {
        var slow = head;
        var fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        var curr = slow.next;
        slow.next = null;
        ListNode prev = null;
        while (curr != null) {
            var nextTemp = curr.next;
            curr.next = prev;

            prev = curr;
            curr = nextTemp;
        }
        
        while (head != null && prev != null) {
            var temp1 = head.next;
            var temp2 = prev.next;
            head.next = prev;
            prev.next = temp1;
            head = temp1;
            prev = temp2;
        }
    }
}
