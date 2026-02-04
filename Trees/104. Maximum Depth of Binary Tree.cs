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
    public int MaxDepth(TreeNode root) {
        if(root is null)
            return 0;

        if(root.left is null && root.right is null)
            return 1;
        
        var leftDepth = MaxDepth(root.left);
        var rightDepth = MaxDepth(root.right);

        return 1 + Math.Max(leftDepth, rightDepth); 
    }
}