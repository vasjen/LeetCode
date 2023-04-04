namespace LeetCode.Problem1909{
//1909. Remove One Element to Make the Array Strictly Increasing
//https://leetcode.com/problems/remove-one-element-to-make-the-array-strictly-increasing/
/*
Given a 0-indexed integer array nums, return true if it can be made strictly increasing after removing exactly one element, 
or false otherwise. If the array is already strictly increasing, return true.

The array nums is strictly increasing if nums[i - 1] < nums[i] for each index (1 <= i < nums.length).

*/
  public class Better {
     
     public bool CanBeIncreasing(int[] nums) {
      int counter = 0;
        for (int i = 1; i < nums.Length; i++)
        {
           if (nums[i - 1] >= nums[i])
            {
              counter++;
              var prev = i > 1 ? nums[i - 2] : int.MinValue;
              var next = i < nums.Length - 1 ? nums[i + 1] : int.MaxValue;
              if (nums[i] <= prev && nums[i - 1] >= next)
                return false; 
            }
        }
        return counter > 1 ? false : true;
  }
} 
}