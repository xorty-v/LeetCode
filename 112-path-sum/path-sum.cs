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
    public bool HasPathSum(TreeNode root, int targetSum) 
    {
        if (root == null) 
            return false;

        var stack = new Stack<TreeNode>();
	    stack.Push(root);
        root.val = targetSum - root.val;

        while(stack.Count() != 0)
        {
            TreeNode currentNode = stack.Pop();
        
            if(currentNode.left == null && currentNode.right == null && currentNode.val == 0)
                return true;

            if(currentNode.left != null){
                currentNode.left.val = currentNode.val - currentNode.left.val;
                stack.Push(currentNode.left);
            }

            if(currentNode.right != null){
                currentNode.right.val = currentNode.val - currentNode.right.val;
                stack.Push(currentNode.right);
            }
        }

        return false;
    }
}