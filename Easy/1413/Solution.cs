namespace LeetCode.Problem1413{
//1413. Minimum Value to Get Positive Step by Step Sum
//https://leetcode.com/problems/minimum-value-to-get-positive-step-by-step-sum/
/*
Given an array of integers nums, you start with an initial positive value startValue.

In each iteration, you calculate the step by step sum of startValue plus elements in nums (from left to right).

Return the minimum positive value of startValue such that the step by step sum is never less than 1.
*/
  public class Solution {
  public int MinStartValue(int[] nums) {
      int[] sum = new int[nums.Length];
      sum[0] = nums[0];
      int minSum = 0;
      for (int i = 1; i < nums.Length; i++)
      {   
          sum[i] = sum[i-1] + nums[i];
          minSum = Math.Min(minSum, sum[i]);
      }
      return Math.Abs(Math.Min(nums[0],minSum)) + 1;
  }

}
}