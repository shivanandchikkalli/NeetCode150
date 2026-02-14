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
    public int GoodNodes(TreeNode root) {
        if(root is null)
            return 0;
        if(root.left is null && root.right is null)
            return 1;

        int count = 1;

        void goodNode(TreeNode node, int maxNode)
        {
            if(node.val >= maxNode) {
                count++;
                maxNode = Math.Max(maxNode, node.val);
            }
            if(node.left is not null)
                goodNode(node.left, maxNode);
            if(node.right is not null)
                goodNode(node.right, maxNode);
        }

        if(root.left is not null)
            goodNode(root.left, root.val);
        if(root.right is not null)
            goodNode(root.right, root.val);

        return count;
    }
}