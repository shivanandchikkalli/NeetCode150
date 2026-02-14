/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root is null)
            return null;

        var nodePathList = new List<TreeNode>();
        if(p.val == root.val || q.val == root.val)
            return root;

        var temp = root;
        while(temp.val != p.val)
        {
            nodePathList.Add(temp);
            if(p.val < temp.val)
                temp = temp.left;
            else
                temp = temp.right;
        }
        nodePathList.Add(temp);
        
        temp = root;
        var prevNode = root;
        int i = 0;
        while(temp is not null)
        {
            if(i < nodePathList.Count() && temp.val == nodePathList[i].val)
                prevNode = nodePathList[i];
                
            if(q.val < temp.val)
                temp = temp.left;
            else if(q.val > temp.val)
                temp = temp.right;
            else
                break;

            i++;
        }

        return prevNode;
    }
}