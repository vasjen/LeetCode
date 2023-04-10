
namespace LeetCode.Problem1991{
//1991. Find the Middle Index in Array
//https://leetcode.com/problems/find-the-middle-index-in-array/
/*
Given a 0-indexed integer array nums, find the leftmost middleIndex (i.e., the smallest amongst all the possible ones).

A middleIndex is an index where nums[0] + nums[1] + ... + nums[middleIndex-1] == nums[middleIndex+1] + nums[middleIndex+2] + ... + 
nums[nums.length-1].

If middleIndex == 0, the left side sum is considered to be 0. Similarly, if middleIndex == nums.length - 1, the right side sum is considered to be 0.

Return the leftmost middleIndex that satisfies the condition, or -1 if there is no such index.
*/
  public class Solution {
    
    
    public int FindMiddleIndex(int[] nums) {
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