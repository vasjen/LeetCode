namespace LeetCode.Medium.Problem209{
//209. Minimum Size Subarray Sum
//https://leetcode.com/problems/minimum-size-subarray-sum/
/*
Given an array of positive integers nums and a positive integer target, return the minimal length of a 
subarray
 whose sum is greater than or equal to target. If there is no such subarray, return 0 instead.
*/
public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0;
        int ans = int.MaxValue;
        int sum = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            sum += nums[right];

            while (sum >= target)
            {
                ans = Math.Min(ans, right - left + 1);
                sum -= nums[left];
                left++;
            }
        }
        return ans == int.MaxValue ? 0 : ans;
    }
}
}