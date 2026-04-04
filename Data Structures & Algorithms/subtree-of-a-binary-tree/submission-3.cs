public class Solution {    
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (root == null) return false;
        if (subRoot == null) return true;
        if (IsSameTree(root, subRoot)) return true;

        var leftIsSubTree = IsSubtree(root.left, subRoot);
        var rightIsSubTree = IsSubtree(root.right, subRoot);

        return leftIsSubTree || rightIsSubTree;
    }

    private bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null) return true;
        if (p == null || q == null) return false;

        var leftSame = IsSameTree(p.left, q.left);
        var rightSame = IsSameTree(p.right, q.right);

        return p.val == q.val && leftSame && rightSame;
    }
}
