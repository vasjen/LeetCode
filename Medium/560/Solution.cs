namespace LeetCode.Medium.Problem560{
//560. Subarray Sum Equals K
//https://leetcode.com/problems/subarray-sum-equals-k
/*
Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.

A subarray is a contiguous non-empty sequence of elements within an array.
*/
public class Solution {
    public int SubarraySum(int[] nums, int k) {
     Dictionary <int,int> dic = new Dictionary <int,int>();
     int ans = 0;
     int sum = 0;
     dic.Add(0,1);
     for (int i = 0; i < nums.Length; i++)
     {
         sum += nums[i];
         if (dic.ContainsKey(sum - k))
            ans += dic[sum-k];
        if (dic.ContainsKey(sum)) {
            dic[sum] += 1;
        } 
        else {
            dic.Add(sum, 1);
        }
     }
     return ans;
    }
}
}