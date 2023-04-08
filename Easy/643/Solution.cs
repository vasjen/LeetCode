namespace LeetCode.Problem643{
//643. Maximum Average Subarray I
//https://leetcode.com/problems/maximum-average-subarray-i/
/*
You are given an integer array nums consisting of n elements, and an integer k.

Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. 
Any answer with a calculation error less than 10-5 will be accepted.
*/ 
 public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double ans = 0;
        int sum = 0;
        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
            
        }
        ans = (double)sum / k;
        for (int i = k; i < nums.Length; i++)
        {
            sum -= nums[i - k];
            sum += nums[i];
            ans = Math.Max(ans, (double)sum / k);
        }
        return ans;
        
    }
}
} 