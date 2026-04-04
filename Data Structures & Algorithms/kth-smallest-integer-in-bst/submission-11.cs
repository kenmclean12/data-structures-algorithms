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
    private int count = 0;
    private int result = 0;
    public int KthSmallest(TreeNode root, int k) {
        Evaluate(root, k);
        return result;
    }

    private void Evaluate(TreeNode root, int k) {
        if (root == null) return;

        Evaluate(root.left, k);

        count++;
        if (count == k) {
            result = root.val;
        }

        Evaluate(root.right, k);
    }
}
