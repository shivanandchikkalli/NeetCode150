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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return GenerateFromTraversal(inorder, preorder, 0, inorder.Length - 1);
    }

    private int preIndex = 0;

    private int SearchInorder(int[] inorder, int start, int end, int value)
    {
        for (int i = start; i <= end; i++)
        {
            if (inorder[i] == value)
                return i;
        }
        return -1;
    }

    public TreeNode GenerateFromTraversal(int[] inorder, int[] preorder, int inStart, int inEnd)
    {
        if (inStart > inEnd)
            return null;

        // Create node from current preorder element
        TreeNode node = new TreeNode(preorder[preIndex++]);

        // If this node has no children
        if (inStart == inEnd)
            return node;

        // Find index of this node in inorder array
        int splitIndex = SearchInorder(inorder, inStart, inEnd, node.val);

        // Recursively construct left and right subtrees
        node.left = GenerateFromTraversal(inorder, preorder, inStart, splitIndex - 1);
        node.right = GenerateFromTraversal(inorder, preorder, splitIndex + 1, inEnd);

        return node;
    }
}