
var sol = new LeetCode.Problem2224.Solution();
var current0 = "02:30";
var correct0 = "04:35";
var ans0 = sol.ConvertTime(current0,correct0);
System.Console.WriteLine("Current: {0}, correct: {1}, min steps: {2}",current0,correct0,ans0);

var current1 = "11:00";
var correct1 = "11:01";
var ans1 = sol.ConvertTime(current1,correct1);
System.Console.WriteLine("Current: {0}, correct: {1}, min steps: {2}",current1,correct1,ans1);

var current2 = "11:01";
var correct2 = "11:00";
var ans2 = sol.ConvertTime(current2,correct2);
System.Console.WriteLine("Current: {0}, correct: {1}, min steps: {2}",current2,correct2,ans2);


