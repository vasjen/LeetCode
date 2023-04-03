namespace LeetCode.Problem2057{
//2057. Smallest Index With Equal Value
//https://leetcode.com/problems/find-greatest-common-divisor-of-array/
/*
Given a 0-indexed integer array nums, return the smallest index i of nums such that i mod 10 == nums[i], or -1 
if such index does not exist.

x mod y denotes the remainder when x is divided by y.
*/
  public class Solution {
   public int SmallestEqual(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
        {
          if (nums[i] == i % 10)
            return i;
        }

        return -1;
    }
}
} 