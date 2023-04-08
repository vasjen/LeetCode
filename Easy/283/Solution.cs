namespace LeetCode.Problem283{
//283. Move Zeroes
//https://leetcode.com/problems/move-zeroes/
/*
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.
*/

// Definition for a binary tree node.

 
  public class Solution {
   public void MoveZeroes(int[] nums) {
        int left = 0;
        int right = 0;
       
           while (left < nums.Length-1)
        {
            while (nums[left] !=0 && left < nums.Length-1)
                left++;
            while (nums[right] == 0 && right < nums.Length-1)
                right++;
            if (nums[left] == 0 && left < nums.Length-1)
            {
                if (left > right)
                {
                    right = left;
                    while (nums[right] == 0 && right < nums.Length-1)
                        right++;
                }
                nums[left] = nums[right];
                nums[right] = 0;
                left++;
            }    
        }
    }
    }
  }
