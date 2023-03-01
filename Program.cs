// See https://aka.ms/new-console-template for more information



var sol = new LeetCode.Problem14.Solution();
var converting = new string[] {"flower","flow","flight"};
var converting2 = new string[] {"dog","racecar","car"};
var converting3 = new string[] {"a"};
var converting4 = new string[] {""};
var ans = sol.LongestCommonPrefix(converting);
var  ans2 = sol.LongestCommonPrefix(converting2);
var ans3 = sol.LongestCommonPrefix(converting3);
var ans4 = sol.LongestCommonPrefix(converting4);
System.Console.WriteLine(ans);
System.Console.WriteLine(ans2);
System.Console.WriteLine(ans3);
System.Console.WriteLine(ans2);

