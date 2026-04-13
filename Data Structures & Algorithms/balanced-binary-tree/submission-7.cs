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
    public bool IsBalanced(TreeNode root) {
       bool result = Height(root) != -1;
       return result;
    }

    private int Height(TreeNode root) {
        if (root == null) return 0;

        int left = Height(root.left);
        if (left == -1) return -1;

        int right = Height(root.right);
        if (right == -1) return -1;

        if (Math.Abs(left - right) > 1) return -1;
        return 1 + Math.Max(left, right);
    }
}
