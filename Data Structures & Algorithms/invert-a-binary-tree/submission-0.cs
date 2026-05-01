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
    public TreeNode InvertTree(TreeNode root) {
        if (root == null) return null;
        Stack<TreeNode> stack = new();
        stack.Push(root);
        while (stack.Count > 0) {
            var node = stack.Pop();
            if (node.left == null && node.right == null) continue;
            var left = node.left;
            node.left = node.right;
            node.right = left;
            if (node.left != null) stack.Push(node.left);
            if (node.right != null) stack.Push(node.right);
        }
        return root;
    }
}
