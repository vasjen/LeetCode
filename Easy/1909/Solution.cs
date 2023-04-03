namespace LeetCode.Problem1909{
//1909. Remove One Element to Make the Array Strictly Increasing
//https://leetcode.com/problems/remove-one-element-to-make-the-array-strictly-increasing/
/*
Given a 0-indexed integer array nums, return true if it can be made strictly increasing after removing exactly one element, 
or false otherwise. If the array is already strictly increasing, return true.

The array nums is strictly increasing if nums[i - 1] < nums[i] for each index (1 <= i < nums.length).

*/
  public class Solution {
     
    public bool CanBeIncreasing(int[] nums) {
        
        for (int i = 0; i < nums.Length; i++)
        {
          List<int> newNums = nums.ToList();
          newNums.RemoveAt(i);
          if (newNums.SequenceEqual(newNums.OrderBy(p => p)) && (newNums.GroupBy(p => p).Count() == newNums.Count))
            return true;
        }
        
        return false;
    }
} 
}