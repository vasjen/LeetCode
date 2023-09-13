
namespace LeetCode.Problem977.Alternative{
//977. Squares of a Sorted Array
//https://leetcode.com/problems/squares-of-a-sorted-array/description/
/*
Given an integer array nums sorted in non-decreasing order, 
return an array of the squares of each number sorted in non-decreasing order.



*/
  public class Solution {
    public int[] SortedSquares(int[] nums) {
        var ans = new int[nums.Length];
        int left = 0; 
        int right = ans.Length - 1;
        for (int i = ans.Length - 1; i >= 0; i--)
        {
            int num;
            if (Math.Abs(nums[right]) > Math.Abs(nums[left]))
            {
                num = nums[right];
                right--;
            }
            else
            {
                num = nums[left];
                left++;
            }
                ans[i] = num * num;
        }
        return ans;
    }
}
    
}
