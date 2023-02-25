// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var sol = new LeetCode.Problem925.Solution();
var ans = sol.IsLongPressedName("alex","aaleex");
System.Console.WriteLine(ans);
System.Console.WriteLine("");
ans = sol.IsLongPressedName("saeed", "ssaaedd");
System.Console.WriteLine(ans);
System.Console.WriteLine("");

ans = sol.IsLongPressedName("a", "b");

System.Console.WriteLine(ans);
System.Console.WriteLine("");
ans = sol.IsLongPressedName("alex", "aaleexa");
System.Console.WriteLine(ans);

System.Console.WriteLine("");
ans = sol.IsLongPressedName("leelee", "lleeelee");
System.Console.WriteLine(ans);

ans = sol.IsLongPressedName("alexd", "ale");
System.Console.WriteLine(ans);


