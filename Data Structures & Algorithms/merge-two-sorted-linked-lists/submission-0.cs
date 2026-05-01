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
        var temp = new ListNode();
        var head = temp;
        while (list1 != null || list2 != null) {
            var val1 = list1 != null ? list1.val : int.MaxValue;
            var val2 = list2 != null ? list2.val : int.MaxValue;

            if (val1 < val2) {
                temp.next = list1;
                list1 = list1.next;
            } else {
                temp.next = list2;
                list2 = list2.next;
            }
            temp = temp.next;
        }
        return head.next;
    }
}