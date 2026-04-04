public class Solution {
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (subRoot == null) return true;
        if (root == null) return false;
        if (IsSameTree(root, subRoot)) return true;

        bool left = IsSubtree(root.left, subRoot);
        bool right = IsSubtree(root.right, subRoot);

        return left || right;
    }

    private bool IsSameTree(TreeNode tree1, TreeNode tree2) {
        if (tree1 == null && tree2 == null) return true;
        if (tree1 == null || tree2 == null) return false;

        bool leftSame = IsSameTree(tree1.left, tree2.left);
        bool rightSame = IsSameTree(tree1.right, tree2.right);

        return tree1.val == tree2.val && leftSame && rightSame;
    }
}
