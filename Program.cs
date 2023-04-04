using LeetCode.Problem637;
var sol = new LeetCode.Problem637.Solution();
TreeNode node0 = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
TreeNode node1 = new TreeNode(2147483647, new TreeNode(2147483647), new TreeNode(2147483647));

var ans0 = sol.AverageOfLevels(node0);
foreach (var item in ans0)
{
    System.Console.WriteLine(item);
}

var ans1 = sol.AverageOfLevels(node1);
foreach (var item in ans1)
{
    System.Console.WriteLine(item);
}



