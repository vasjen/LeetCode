namespace LeetCode.Problem35{
//35. Search Insert Position
//https://leetcode.com/problems/search-insert-position/
/*
Given a sorted array of distinct integers and a target value, return the index if the target is found. 
If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.
*/
  public class Solution {
     public int SearchInsert(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        int mid = 0;
        while (left <= right)
        {
            mid = left + (right - left) / 2;
            if (nums[mid] == target)
                return mid;
            if (target < nums[mid])
               right = mid - 1;
            else left = mid + 1;
        }
        return left;
    }
  }
}