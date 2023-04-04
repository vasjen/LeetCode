namespace LeetCode.Problem1909{
//1909. Remove One Element to Make the Array Strictly Increasing
//https://leetcode.com/problems/remove-one-element-to-make-the-array-strictly-increasing/
/*
Given a 0-indexed integer array nums, return true if it can be made strictly increasing after removing exactly one element, 
or false otherwise. If the array is already strictly increasing, return true.

The array nums is strictly increasing if nums[i - 1] < nums[i] for each index (1 <= i < nums.length).

*/
  public class Alternative {
     
    public bool CanBeIncreasing(int[] nums) {
        bool ans = false;
        for (int i = 0; i < nums.Length; i++)
        {
           ans = Comparer(nums.Select( (p,index) => new{
            
            index = index,
            val = p
          })
          .Where(p => p.index != i)
          .Select(p => p.val).ToArray());
          if (ans == true)
            return true;
        }
        
        return false;
    }
  public bool Comparer(int[] nums)
  {
      int val = nums[0];
      for (int i = 1; i < nums.Length; i++)
      {
        if (nums[i] <= val)
          return false;
        val = nums[i];
      }
      return true;
  }
} 
}