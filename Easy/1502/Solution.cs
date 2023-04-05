namespace LeetCode.Problem1502{
//1502. Can Make Arithmetic Progression From Sequence
//https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence/
/*
A sequence of numbers is called an arithmetic progression if the difference between any two consecutive elements is the same.

Given an array of numbers arr, return true if the array can be rearranged to form an arithmetic progression. Otherwise, return false.


*/
  public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        var nums = arr.OrderBy(p => p).ToArray();
        var diff = Math.Abs(nums[1] - nums[0]);
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] == diff)
              diff = nums[i] - nums[i - 1];
            else
                return false;
        }
        return true;
    }
  }
} 