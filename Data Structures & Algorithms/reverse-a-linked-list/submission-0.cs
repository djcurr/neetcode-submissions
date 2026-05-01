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
//  temp -> temp.next
//  temp.next -> temp
//  head [0, 1, 2, 3]
//  curr []
//  prev [3, 2, 3, 1, 0]
//  nextTemp []
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode curr = head;
        ListNode prev = null;
        while (curr != null) {
            ListNode nextTemp = curr.next;

            curr.next = prev;
            prev = curr;
            curr = nextTemp;
        }
        return prev;
    }
}
