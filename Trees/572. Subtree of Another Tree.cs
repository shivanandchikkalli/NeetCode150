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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (subRoot is null)
            return true;
        if (root is null)
            return false;

        bool IsSameTree(TreeNode p, TreeNode q) 
        {
            if(p is null && q is null)
                return true;
            else if((p is null && q is not null) || (p is not null && q is null))
                return false;

            if(p.val != q.val)
                return false;

            bool isLeftSameTree = IsSameTree(p.left, q.left);
            bool isRightSameTree = IsSameTree(p.right, q.right);

            return isLeftSameTree && isRightSameTree;
        }

        if (IsSameTree(root, subRoot))
            return true;

        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }
}