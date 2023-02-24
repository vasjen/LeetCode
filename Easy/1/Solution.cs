namespace LeetCode.Problem1{
//1. Two Sum
//https://leetcode.com/problems/two-sum/
/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] Out = new int[2];
        for (int i=0;i<nums.Length;i++)
        {
            int second=target-nums[i];
                 for (int j=i+1;j<nums.Length;j++)
                 {  
                        if (nums[j]==second)
                        {
                            Out[0]=i;
                            Out[1]=j;
                            break;
                        }
                 }
                
        }
            return Out;
    }
}
}