namespace LeetCode.Problem637{
//637. Average of Levels in Binary Tree
//https://leetcode.com/problems/average-of-levels-in-binary-tree/
/*
Given the root of a binary tree, return the average value of the nodes on each level in the form of an array. 
Answers within 10-5 of the actual answer will be accepted.
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
    List<IEnumerable<long>> nodes = new List<IEnumerable<long>>();
    List<double> averageNodes = new List<double>();
    int level = 0;
    public IList<double> AverageOfLevels(TreeNode root) {
       
       ListAllNodes(root);
       var levelNodes = nodes.GroupBy(p => p.FirstOrDefault()).ToList();
       foreach (var item in levelNodes)
       {
        averageNodes.Add((double)item.Sum(p => p.LastOrDefault()) / item.Count());
       }
       return averageNodes;

    }
    public List<IEnumerable<long>> ListAllNodes (TreeNode root)
    {
        if (root != null){
            
            nodes.Add(new long[] {level,root.val});
            level++;
            if (root.left!=null)
                ListAllNodes(root.left);
            if (root.right!=null)
                ListAllNodes(root.right);
        }
        level--;
        return nodes;
    }
}
} 