
var sol = new LeetCode.Problem1812.Solution();
var coor0 = "a1";
var ans0 = sol.SquareIsWhite(coor0);
System.Console.WriteLine("For coor '{0}' square is white? {1}",coor0,ans0);

var coor1 = "h3";
var ans1 = sol.SquareIsWhite(coor1);
System.Console.WriteLine("For coor '{0}' square is white? {1}",coor1,ans1);

var coor2 = "c7";
var ans2 = sol.SquareIsWhite(coor2);
System.Console.WriteLine("For coor '{0}' square is white? {1}",coor2,ans2);

for (char a = 'a'; a<='h'; a++)
{
    System.Console.WriteLine("For {0} white? {1}",$"{a}1",sol.SquareIsWhite(new string(a+"1")));
}
