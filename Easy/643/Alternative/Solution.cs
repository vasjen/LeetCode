namespace LeetCode.Problem643.Alternative{
//643. Maximum Average Subarray I
//https://leetcode.com/problems/maximum-average-subarray-i/
/*
You are given an integer array nums consisting of n elements, and an integer k.

Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. 
Any answer with a calculation error less than 10-5 will be accepted.
*/ 
 public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int left = 0;
        int right = 0;
        double average = double.MinValue;
        int Sum = 0;
        while (right < nums.Length)
        {
            while (right - left  < k )
            {
                Sum += nums[right++];
            }
            average = Math.Max(average, (double)Sum / k);
            Sum -= nums[left++];
        }
        return average;
        
    }
}
} 