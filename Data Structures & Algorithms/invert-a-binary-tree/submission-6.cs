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

       TreeNode invertedLeft = InvertTree(root.left);
       TreeNode invertedRight = InvertTree(root.right);

       root.left = invertedRight;
       root.right = invertedLeft;

       return root;
    }
}
