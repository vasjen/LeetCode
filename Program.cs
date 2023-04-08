
var sol = new LeetCode.Problem977.Solution();
var nums0 = new int[]{-4,-1,0,3,10};
    
//var ans0 = sol.FindJudge(3,trust0);
var trust1 = new int[][]{
    new int[] {1,3},
    new int[] {1,4},
    new int[] {2,3},
    new int[] {2,4},
    new int[] {4,3},
};
var ans0 = sol.SortedSquares(nums0);
foreach (var item in ans0)
{
    System.Console.Write($"{item} ");
}




