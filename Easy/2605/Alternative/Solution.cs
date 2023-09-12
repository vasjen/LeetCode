namespace LeetCode.Problem2605.Alternative{
//2605. Form Smallest Number From Two Digit Arrays
//https://leetcode.com/problems/form-smallest-number-from-two-digit-arrays/
/*
Given two arrays of unique digits nums1 and nums2, 
return the smallest number that contains at least one digit from each array.
*/
  public class Solution {
    public int MinNumber(int[] nums1, int[] nums2) {
      
       var sharing = nums1.Intersect(nums2);
       var min1 = nums1.Min();
       var min2 = nums2.Min();
       if (sharing.Any())
        return Math.Min(sharing.Min(), 
            Math.Min(int.Parse(min1.ToString() + min2.ToString()), 
                int.Parse(min2.ToString() + min1.ToString())));
        else 
            return Math.Min(int.Parse(min1.ToString() + min2.ToString()), 
                int.Parse(min2.ToString() + min1.ToString()));
     }
}
} 