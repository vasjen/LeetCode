
namespace LeetCode.Problem1732{
//1732. Find the Highest Altitude
//https://leetcode.com/problems/find-the-highest-altitude/
/*
There is a biker going on a road trip. The road trip consists of n + 1 points at different altitudes. 
The biker starts his trip on point 0 with altitude equal 0.

You are given an integer array gain of length n where gain[i] is the net gain in altitude between points i​​​​​​ and i + 1 for all (0 <= i < n). 
Return the highest altitude of a point.
*/
  public class Solution {
    
   
     public int LargestAltitude(int[] gain) {
        int[] altitude = new int[gain.Length + 1];
        altitude[0] = 0;
        int max = 0;
        for (int i = 1; i <= gain.Length; i++){
            altitude[i] = altitude[i-1] + gain[i-1];
            max = Math.Max(max, altitude[i]);
        }
        return max;
    }
  }
} 