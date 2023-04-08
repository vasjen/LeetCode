namespace LeetCode.Medium.Problem713{
//713. Subarray Product Less Than K
//https://leetcode.com/problems/subarray-product-less-than-k/
/*
Given an array of integers nums and an integer k, return the number of contiguous subarrays 
where the product of all the elements in the subarray is strictly less than k.
*/
public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
    
     if (k <= 1)
        return 0;
    int left = 0;
    int curr = 1;
    int ans = 0;

    for (int right = 0; right < nums.Length; right++) {

        curr *= nums[right];
        while (curr >= k && left <= right) {
            curr /= nums[left];
            left++;
        }
        ans += right - left + 1;
    }

    return ans;
    }
}
}