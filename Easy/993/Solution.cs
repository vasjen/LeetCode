
using LeetCode.Problem637;

namespace LeetCode.Problem993{
//993. Cousins in Binary Tree
//https://leetcode.com/problems/cousins-in-binary-tree/
/*
Given the root of a binary tree with unique values and the values of two different nodes of the tree x and y, 
return true if the nodes corresponding to the values x and y in the tree are cousins, or false otherwise.

Two nodes of a binary tree are cousins if they have the same depth with different parents.

Note that in a binary tree, the root node is at the depth 0, and children of each depth k node are at the depth k + 1.


*/
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
    Dictionary<int,int> values = new Dictionary<int, int>();
    int level = 0;
    int[] node = new int[2];
    public bool IsCousins(TreeNode root, int x, int y) {
   //   AddToDictionary(root);
   //   if (!values.Keys.Contains(x) || !values.Keys.Contains(y))
   //     return false;
   //   foreach (var item in values)
   //   {
   //     System.Console.WriteLine("{0} - {1} level",item.Key,item.Value);
   //   }
   //   return (values[x] == values[y]);
    FindNode(root,x);
    int[] xNode = new int [2];
    node.CopyTo(xNode,0);
    FindNode(root,y);
    int[] yNode = new int [2];
    node.CopyTo(yNode,0);
  
    
     
    return xNode[0] == yNode[0] && xNode[1] != yNode[1];
    }
  
    private void FindNode(TreeNode root, int value){
    
       level++;
       if (root?.left?.val == value || root?.right?.val == value)
       {
        node[0] = level;
        node[1] = root.val;
       }
      if (root?.left != null)
        FindNode(root.left,value);
      if (root?.right != null)
        FindNode(root.right,value);
      level --;
  }
} 
}