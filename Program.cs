
var sol = new LeetCode.Problem2144.Solution();

int[] cost0 = new[] {1,2,3};
var ans0 = sol.MinimumCost(cost0);
System.Console.WriteLine("minimum cost is {0}", ans0);

int[] cost1 = new[] {6,5,7,9,2,2};
var ans1 = sol.MinimumCost(cost1);
System.Console.WriteLine("minimum cost is {0}", ans1);

int[] cost2 = new[] {5,5};
var ans2 = sol.MinimumCost(cost2);
System.Console.WriteLine("minimum cost is {0}", ans2);

int[] cost3 = new[] {5,1,1,5};
var ans3 = sol.MinimumCost(cost3);
System.Console.WriteLine("minimum cost is {0}", ans3);

int[] cost4 = new[] {1,1,1,1,1};
var ans4 = sol.MinimumCost(cost4);
System.Console.WriteLine("minimum cost is {0}", ans4);

int[] cost5 = new[] {99,99,99,99,1};
var ans5 = sol.MinimumCost(cost5);
System.Console.WriteLine("minimum cost is {0}", ans5);
