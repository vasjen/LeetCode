
using LeetCode.Problem145;

var sol = new LeetCode.Problem145.Solution();
var nums0 = new TreeNode(1, null, new TreeNode(2,new TreeNode(3)));
var ans0 = sol.PostorderTraversal(nums0);

foreach (var item in ans0)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("********************\n");
var nums1 = new TreeNode(3, null, new TreeNode(1,new TreeNode(2)));
var ans1 = sol.PostorderTraversal(nums1);

foreach (var item in ans1)
{
    System.Console.WriteLine(item);
}





