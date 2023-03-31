
var sol = new LeetCode.Problem1725.Solution();
var arr0 = new int[][] {
    new int[] {5,8},
    new int[] {3,9},
    new int[] {5,12},
    new int[] {16,5},

};
var ans0 = sol.CountGoodRectangles(arr0);
System.Console.WriteLine("Answer is {0}",ans0);

var arr1 = new int[][] {
    new int[] {2,3},
    new int[] {3,7},
    new int[] {4,3},
    new int[] {3,7},

};
var ans1 = sol.CountGoodRectangles(arr1);
System.Console.WriteLine("Answer is {0}",ans1);