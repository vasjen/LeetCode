
var sol = new LeetCode.Problem1417.Solution();
var num0 = "a0b1c2";
var ans0 = sol.Reformat(num0);
System.Console.WriteLine("String is {0}, ans is {1}",num0,ans0);

var num1 = "leetcode";
var ans1 = sol.Reformat(num1);
System.Console.WriteLine("String is {0}, ans is {1}",num1,ans1);

var num2 = "a0bdb123c2";
var ans2 = sol.Reformat(num2);
System.Console.WriteLine("String is {0}, ans is {1}",num2,ans2);

var num3 = "2cg45h";
var ans3 = sol.Reformat(num3);
System.Console.WriteLine("String is {0}, ans is {1}",num3,ans3);

var num4 = "2cg45hf";
var ans4 = sol.Reformat(num4);
System.Console.WriteLine("String is {0}, ans is {1}",num4,ans4);

