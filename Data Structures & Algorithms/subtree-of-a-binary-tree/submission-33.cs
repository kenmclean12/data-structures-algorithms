public class Solution {
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
       if (subRoot == null) return true;
       if (root == null) return false;
       if (IsSameTree(root, subRoot)) return true;

       bool left = IsSubtree(root.left, subRoot);
       bool right = IsSubtree(root.right, subRoot);

       return left || right;
    }

    private bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null) return true;
        if (p == null || q == null) return false;

        bool leftSame = IsSameTree(p.left, q.left);
        bool rightSame = IsSameTree(p.right, q.right);

        return p.val == q.val && leftSame && rightSame;
    }
}
