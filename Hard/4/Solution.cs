namespace LeetCode.Hard.Problem4 {
//4. Median of Two Sorted Arrays
//https://leetcode.com/problems/median-of-two-sorted-arrays/
/*
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).
*/
public class Solution {

    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
       
        var merged = nums1.Concat(nums2).OrderBy(p => p).ToList();
        var n = merged.Count;
        if (n % 2 != 0)
            return merged[n/2];
        else
            return (double)(merged[n/2-1] + merged[n/2])/2;
    }
}
}