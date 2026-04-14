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
    int count = 0;
    public int GoodNodes(TreeNode root) {
      Dfs(root, root.val);
      return count;
    }

    private void Dfs(TreeNode root, int maxValue) {
       if (root == null) return;
       if (root.val >= maxValue) count++;
       maxValue = Math.Max(maxValue, root.val);
       Dfs(root.left, maxValue);
       Dfs(root.right, maxValue);
    }
}
