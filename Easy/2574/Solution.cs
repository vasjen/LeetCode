namespace LeetCode.Problem2574{
//2574. Left and Right Sum Differences
//https://leetcode.com/problems/left-and-right-sum-differences/
/*
Given a 0-indexed integer array nums, find a 0-indexed integer array answer where:

answer.length == nums.length.
answer[i] = |leftSum[i] - rightSum[i]|.
Where:

leftSum[i] is the sum of elements to the left of the index i in the array nums. If there is no such element, leftSum[i] = 0.
rightSum[i] is the sum of elements to the right of the index i in the array nums. If there is no such element, rightSum[i] = 0.
Return the array answer.
*/
  public class Solution {
    
   
  public int[] LeftRigthDifference(int[] nums) {
       int[] ans = new int[nums.Length];
       int[] sum = new int[nums.Length + 1];
       sum[0] = 0;
       
       for (int i = 1; i <= nums.Length; i++)
       {
           sum[i] = nums[i-1] + sum[i-1];
       }
        for (int i = 0; i < ans.Length; i++)
       {
           ans[i] = Math.Abs(sum[nums.Length] - sum[i + 1] - sum[i]);
       }
       return ans;
    }
  }
} 