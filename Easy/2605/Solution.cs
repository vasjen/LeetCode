namespace LeetCode.Problem2605{
//2605. Form Smallest Number From Two Digit Arrays
//https://leetcode.com/problems/form-smallest-number-from-two-digit-arrays/
/*
Given two arrays of unique digits nums1 and nums2, 
return the smallest number that contains at least one digit from each array.
*/
  public class Solution {
    public int MinNumber(int[] nums1, int[] nums2) {
      
       int first = 0;
       int[] sorted = nums1.OrderBy(p => p).ToArray();
       for (int i = 0; i < nums1.Length; i++)
       {
           first = sorted[i];
           if (nums2.Contains(first))
            return first;
       }
        first = nums1.Min();
       var second = nums2.Min();
       return Math.Min(first,second) * 10 + Math.Max(first,second);
    }
}
} 