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
    private Dictionary<int, int> inorderMap = new();
    int preorderIndex = 0;
    
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for (int i = 0; i < inorder.Length; i++) {
            inorderMap[inorder[i]] = i;
        }

        return Build(preorder, 0, inorder.Length - 1);
    }

    private TreeNode Build(int[] preorder, int left, int right) {
        if (left > right) return null;

        int rootVal = preorder[preorderIndex++];
        TreeNode root = new TreeNode(rootVal);
        int inorderIndex = inorderMap[rootVal];

        root.left = Build(preorder, left, inorderIndex - 1);
        root.right = Build(preorder, inorderIndex + 1, right);

        return root;
    }
}
