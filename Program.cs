// See https://aka.ms/new-console-template for more information



var sol = new LeetCode.Problem13.Solution();
string converting = "III";
var ans = sol.RomanToInt(converting);
System.Console.WriteLine("Convert from {0}",converting);
System.Console.WriteLine(ans);
 
converting = "LVIII";
ans = sol.RomanToInt(converting);
System.Console.WriteLine("Convert from {0}",converting);
System.Console.WriteLine(ans);

converting = "MCMXCIV";
ans = sol.RomanToInt(converting);
System.Console.WriteLine("Convert from {0}",converting);
System.Console.WriteLine(ans);

