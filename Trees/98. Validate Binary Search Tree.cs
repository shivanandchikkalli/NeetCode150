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
    long prevNum = long.MinValue;
    public bool IsValidBST(TreeNode root) {
        if(root is null)
            return true;

        var lRes = IsValidBST(root.left);

        if(root.val <= prevNum)
            return false;
        prevNum = root.val;

        var rRes = IsValidBST(root.right);
        
        return lRes && rRes;
    }
}