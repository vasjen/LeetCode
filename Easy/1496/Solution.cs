namespace LeetCode.Problem1496{
//1496. Path Crossing
//https://leetcode.com/problems/path-crossing/
/*
Given a string path, where path[i] = 'N', 'S', 'E' or 'W', each representing moving one unit north, 
south, east, or west, respectively. You start at the origin (0, 0) on a 2D plane and walk on the path specified by path.

Return true if the path crosses itself at any point, that is, if at any time you are on a location you have previously visited. 
Return false otherwise.
*/
  public class Solution {
    public bool IsPathCrossing(string path) {
      
     List<int[]> coordinates = new List<int[]>();
     coordinates.Add(new int[]{0,0});
     int[] temp = new int[2];
     for (int i = 0; i < path.Length ; i++)
     {
        coordinates.LastOrDefault().CopyTo(temp = new int[2],0);
        switch(path[i])
        {
          case 'N':
            temp[0]++;
            break;
          case 'S':
            temp[0]--;
            break;
          case 'E':
            temp[1]++;
            break;
          case 'W':
            temp[1]--;
            break;
        }
        coordinates.Add(temp);
     }
   //  System.Console.WriteLine("Coordinates:");
   //  foreach (var item in coordinates)
   //  {
   //   System.Console.WriteLine($"{item[0]};{item[1]}");
   //  }
   // var grouped = coordinates.GroupBy((p) => new {xPos = p[0], yPos = p[1]});
   // System.Console.WriteLine("After gropuping");
   // foreach (var item in grouped)
   // {
   //   System.Console.WriteLine($"{item.Key.xPos};{item.Key.yPos}");
   // }
   // System.Console.WriteLine(grouped.Count());
     return coordinates.GroupBy((p) => new {xPos = p[0], yPos = p[1]}).Count() <= path.Length;   
    }
  }
} 