
using LeetCode.Problem993;

var sol = new LeetCode.Problem993.Solution();

//TreeNode node0 = new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3));
//var ans0 = sol.IsCousins(node0,4,3);
//System.Console.WriteLine("for nums {0} result is {1}",node0,ans0);

//TreeNode node1 = new TreeNode(1, new TreeNode(2, null,new TreeNode(4)), new TreeNode(3));
//var ans1 = sol.IsCousins(node1,2,3);
//System.Console.WriteLine("for nums {0} result is {1}",node1,ans1);

TreeNode node2 = new TreeNode(1, new TreeNode(2, null, new TreeNode(4)), new TreeNode(3, null, new TreeNode(5)));
var ans2 = sol.IsCousins(node2,5,4);
System.Console.WriteLine("for nums {0} result is {1}",node2,ans2);

