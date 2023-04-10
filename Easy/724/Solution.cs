
namespace LeetCode.Problem724{
//724. Find Pivot Index
//https://leetcode.com/problems/find-pivot-index/
/*
Given an array of integers nums, calculate the pivot index of this array.

The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers 
strictly to the index's right.

If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. 
This also applies to the right edge of the array.

Return the leftmost pivot index. If no such index exists, return -1.
*/
  public class Solution {
    
   
    public int PivotIndex(int[] nums) {
        int left = 0;
        int right = nums.Length -1;
        int leftSum = 0;
        int rightSum = 0;
        int Sum = 0;
        for (int i = 0; i < nums.Length; i++)
            Sum += nums[i];
        while (left < nums.Length)
        {
           Sum -= nums[left]; 
           if (leftSum == Sum)
            return left;

           leftSum += nums[left];
           left++;
        }
        return -1;

    }
  }
} 