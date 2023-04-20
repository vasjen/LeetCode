namespace LeetCode.Problem217{
//217. Contains Duplicate
//https://leetcode.com/problems/contains-duplicate/
/*
Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
*/

// Definition for a binary tree node.
  public class Solution {
      public bool ContainsDuplicate(int[] nums) {
        HashSet<int> vals = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var value = nums[i];
            if (vals.Contains(value))
                return true;
            vals.Add(value);
        }
            return false;
    }
    }
  }
