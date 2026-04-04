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
    public int GoodNodes(TreeNode root) {
        Dfs(root, root.val);
        return count;
    }

    private void Dfs(TreeNode node, int maxValue) {
        if (node == null) return;
        if (node.val >= maxValue) count++;
        int currentMax = Math.Max(maxValue, node.val);
        Dfs(node.left, currentMax);
        Dfs(node.right, currentMax);
    }
}
