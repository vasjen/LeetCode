namespace LeetCode.Problem145{
//145. Binary Tree Postorder Traversal
//https://leetcode.com/problems/binary-tree-postorder-traversal/
/*
Given the root of a binary tree, return the postorder traversal of its nodes' values.
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
    List<int> numbers = new List<int>();
   public IList<int> PostorderTraversal(TreeNode root) {
        if (root == null)
            return numbers; 
        numbers.Insert(0,root.val);
        if (root?.right != null)
            PostorderTraversal(root.right);
        if (root?.left != null)
            PostorderTraversal(root.left);
     
            return numbers;
    }
    }
  }
