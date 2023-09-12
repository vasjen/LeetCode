namespace LeetCode.Problem268.Alternative{
//268. Missing Number
//https://leetcode.com/problems/missing-number/
/*
Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
*/
public class Solution {
    public int MissingNumber(int[] nums) {
      
      Array.Sort(nums);
      for (int i = 0; i < nums.Length; i++)
      {
          if (nums[i] != i)
            return i;
      }
      return nums.Length;
    }
}
}
