namespace LeetCode.Problem704{
//704. Binary Search
//https://leetcode.com/problems/binary-search/
/*
Given an array of integers nums which is sorted in ascending order, and an integer target, 
write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.

You must write an algorithm with O(log n) runtime complexity.
*/
public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
                return mid;
            
            if (target > nums[mid])
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }
}
} 