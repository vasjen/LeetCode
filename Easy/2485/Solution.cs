namespace LeetCode.Problem2485{
//2485. Find the Pivot Integer
//https://leetcode.com/problems/find-the-pivot-integer/
/*
Given a positive integer n, find the pivot integer x such that:

The sum of all elements between 1 and x inclusively equals the sum of all elements between x and n inclusively.
Return the pivot integer x. If no such integer exists, return -1. It is guaranteed that there will be at most one pivot 
index for the given input.
*/
  public class Solution {
    
   
    public int PivotInteger(int n) {
      if (n ==1)
        return n;
        
      int x = n-1;
      var sumUntilX = 0;
      for (int i = 1; i <= x; i++)
      {
        sumUntilX += i;
      }
      var sumSinceX = n + x;
      while (x > 1 )
      {
        if (sumSinceX == sumUntilX)
          return x;
        sumUntilX -= x;
        x--;
        sumSinceX += x;
      }

      return -1;  
    }
  }
} 