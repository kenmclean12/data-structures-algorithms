public class Solution {
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (subRoot == null) return true;
        if (root == null) return false;
        if (IsSameTree(root, subRoot)) return true;

        var left = IsSubtree(root.left, subRoot);
        var right = IsSubtree(root.right, subRoot);

        return left || right;
    }

    private bool IsSameTree(TreeNode one, TreeNode two) {
        if (one == null && two == null) return true;
        if (one == null || two == null) return false;

        var leftSame = IsSameTree(one.left, two.left);
        var rightSame = IsSameTree(one.right, two.right);

        return one.val == two.val && leftSame && rightSame;
    }
}
