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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var result = new ListNode();
        var resultTemp = result;
        int carry = 0;
        while (l1 != null || l2 != null) {
            var tempSum = 0;
            if (l1 != null && l2 != null) {
                var cur1 = l1.val;
                var cur2 = l2.val;
                tempSum = cur1 + cur2 + carry;
                l1 = l1.next;
                l2 = l2.next;
            } else if (l1 != null) {
                var cur1 = l1.val;
                tempSum = cur1 + carry;
                l1 = l1.next;
            } else {
                var cur2 = l2.val;
                tempSum = cur2 + carry;
                l2 = l2.next;
            }
            carry = tempSum / 10;
            resultTemp.val = tempSum % 10;
            if (l1 != null || l2 != null) {
                resultTemp.next = new ListNode();
                resultTemp = resultTemp.next;
            }
        } 
        if (carry != 0) {
            resultTemp.next = new ListNode();
            resultTemp.next.val = carry;
        }

        return result;
    }
}
