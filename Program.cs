// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var sol = new LeetCode.Problem896.Alternative();
var ans = sol.IsMonotonic(new int[] {1,2,2,3});
System.Console.WriteLine(ans);
ans = sol.IsMonotonic(new int[] {6,5,4,4});
System.Console.WriteLine(ans);
ans = sol.IsMonotonic(new int[] {1,3,2});
System.Console.WriteLine(ans);
//Additional
ans = sol.IsMonotonic(new int[] {-1,-1,0,3,3});
System.Console.WriteLine(ans);
