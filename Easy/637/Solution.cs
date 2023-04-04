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
    List<IEnumerable<int>> nodes = new List<IEnumerable<int>>();
    List<double> averageNodes = new List<double>();
    int level = 0;
    public IList<double> AverageOfLevels(TreeNode root) {
       
       ListAllNodes(root);
       foreach (var item in nodes.GroupBy(p => p.FirstOrDefault()).ToList())
       {
        averageNodes.Add(item.Sum(p => Convert.ToDouble(p.LastOrDefault())) / item.Count());
       }
       return averageNodes;

    }
    public void ListAllNodes (TreeNode root)
    {
        if (root != null){
            
            nodes.Add(new int[2] {level,root.val});
            level++;
            if (root.left!=null)
                ListAllNodes(root.left);
            if (root.right!=null)
                ListAllNodes(root.right);
        }
        level--;
    }
}
} 