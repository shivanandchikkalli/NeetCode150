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
    public int KthSmallest(TreeNode root, int k) {
        int index = 0;
        bool found = false;
        int returnValue = -1;

        void inorder(TreeNode node)
        {
            if(node is null || found)
                return;
                
            if(!found)
                inorder(node.left);
            index++;
            if(index == k) {
                returnValue = node.val;
                found = true;
            }
            if(!found)
                inorder(node.right);
        }
        inorder(root);
        return returnValue;
    }
}