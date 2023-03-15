namespace LeetCode.Problem112{
//112. Path Sum
//https://leetcode.com/problems/path-sum/
/*
Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.

A leaf is a node with no children.
*/

// Definition for a binary tree node.
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

 
  public class Solution {
        bool ans = false;
   public bool HasPathSum(TreeNode root, int targetSum) {
       
	    if (root?.left == null && root?.right == null) 
        return targetSum == root?.val;
	    return HasPathSum(root.left, targetSum - root.val) 
            || 
            HasPathSum(root.right, targetSum - root.val);
}
    }
  }
