namespace LeetCode.Problem2465{
//2465. Number of Distinct Averages
//https://leetcode.com/problems/number-of-distinct-averages/
/*
You are given a 0-indexed integer array nums of even length.

As long as nums is not empty, you must repetitively:

Find the minimum number in nums and remove it.
Find the maximum number in nums and remove it.
Calculate the average of the two removed numbers.
The average of two numbers a and b is (a + b) / 2.

For example, the average of 2 and 3 is (2 + 3) / 2 = 2.5.
Return the number of distinct averages calculated using the above process.

Note that when there is a tie for a minimum or maximum number, any can be removed.
*/
  public class Solution {
    
   
   public int DistinctAverages(int[] nums) {
        
          if (nums.Length==2)
            return nums.Min();
          
          return (nums.Min()+nums.Max()) / 2;
    }
  }
} 