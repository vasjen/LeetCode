namespace LeetCode.Problem349{
//349. Intersection of Two Arrays
//https://leetcode.com/problems/intersection-of-two-arrays/
/*
Given two integer arrays nums1 and nums2, return an array of their intersection. 
Each element in the result must be unique and you may return the result in any order.
*/
  public class Solution {
   public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);
        foreach (var item in set1)
        {
            if (!set2.Contains(item))
                set1.Remove(item);
        }
        return set1.ToArray();
    }
}
} 