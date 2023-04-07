
var sol = new LeetCode.Problem997.Solution();
var trust0 = new int[][]{
    new int[] {1,2},
    new int[] {2,3},
};
//var ans0 = sol.FindJudge(3,trust0);
var trust1 = new int[][]{
    new int[] {1,3},
    new int[] {1,4},
    new int[] {2,3},
    new int[] {2,4},
    new int[] {4,3},
};
var ans1 = sol.FindJudge(3,trust0);
System.Console.WriteLine("{0} => Answer fo value {1}",ans1,trust1);



