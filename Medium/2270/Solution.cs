namespace LeetCode.Medium.Problem2270{
//2270. Number of Ways to Split Array
//https://leetcode.com/problems/number-of-ways-to-split-array/
/*
You are given a 0-indexed integer array nums of length n.

nums contains a valid split at index i if the following are true:

The sum of the first i + 1 elements is greater than or equal to the sum of the last n - i - 1 elements.
There is at least one element to the right of i. That is, 0 <= i < n - 1.
Return the number of valid splits in nums.
*/
public class Solution {
    public int WaysToSplitArray(int[] nums) {
        long[] sum = new long[nums.Length];
        sum[0] = nums[0];
        int split = 0;
        for (int i = 1; i < nums.Length; i++)
            sum[i] = sum[i - 1] + nums[i];

        for (int i = 0; i < sum.Length - 1; i++)
        {
            if (sum[i] >= sum[sum.Length - 1] - sum[i])
                split++;
        }
        return split;
    }
    }
}
