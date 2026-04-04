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
    private List<int> result = new();
    public List<int> RightSideView(TreeNode root) {
        Dfs(root, 0);
        return result;
    }

    private void Dfs(TreeNode root, int depth) {
        if (root == null) return;
        if (depth == result.Count) result.Add(root.val);

        Dfs(root.right, depth + 1);
        Dfs(root.left, depth + 1);
    }
}
