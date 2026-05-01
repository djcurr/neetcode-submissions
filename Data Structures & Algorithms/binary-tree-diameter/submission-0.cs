/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    private int d = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        db(root);
        return d;
    }

    public int db(TreeNode root) {
        if (root == null) return 0;
        var left = db(root.left);
        var right = db(root.right);
        d = Math.Max(left + right, d);
        return left > right ? left + 1 : right + 1;
    }
}
