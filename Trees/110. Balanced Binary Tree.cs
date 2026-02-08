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
    public bool IsBalanced(TreeNode root) {
        if(root is null)
            return true;
            
        bool isBalanced = true;
        int MaxDepth(TreeNode root) {
            if(root is null)
                return 0;
            
            var leftDepth = MaxDepth(root.left);
            var rightDepth = MaxDepth(root.right);

            isBalanced &= Math.Abs(leftDepth - rightDepth) <= 1;

            return 1 + Math.Max(leftDepth, rightDepth); 
        }

        MaxDepth(root);

        return isBalanced;
    }
}