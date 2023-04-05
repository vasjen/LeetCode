
var sol = new LeetCode.Problem2022.Solution();

var num0 = new int[] {1,2,3,4};
var ans0 = sol.Construct2DArray(num0,2,2);
System.Console.WriteLine("for nums {0} result is {1}",num0,ans0);

var num1 = new int[] {1,2,3};
var ans1 = sol.Construct2DArray(num1,1,3);
System.Console.WriteLine("for nums {0} result is {1}",num1,ans1);

var num2 = new int[] {1,2};
var ans2 = sol.Construct2DArray(num2,1,1);
System.Console.WriteLine("for nums {0} result is {1}",num2,ans2);
