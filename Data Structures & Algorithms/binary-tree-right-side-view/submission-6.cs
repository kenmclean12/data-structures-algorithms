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
    private List<int> list;
    public List<int> RightSideView(TreeNode root) {
      list = new();
      Dfs(root, 0);
      return list;
    }

    private void Dfs(TreeNode root, int depth) {
        if (root == null) return;
        if (depth == list.Count) list.Add(root.val);

        Dfs(root.right, depth + 1);
        Dfs(root.left, depth + 1);
    }
}
