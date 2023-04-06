namespace LeetCode.Problem594{
//594. Longest Harmonious Subsequence
//https://leetcode.com/problems/longest-harmonious-subsequence/
/*
We define a harmonious array as an array where the difference between its maximum value and its minimum value is exactly 1.

Given an integer array nums, return the length of its longest harmonious subsequence among all its possible subsequences.

A subsequence of array is a sequence that can be derived from the array by deleting some or no elements without changing the order 
of the remaining elements.
*/
  public class Solution {
    public int FindLHS(int[] nums) {
       Dictionary<int, int> values = new Dictionary<int, int>();
        int ans = 0;
        foreach (int num in nums) {
            if (values.ContainsKey(num)) 
                values[num]++;
             else 
                values[num] = 1;
            
            if (values.ContainsKey(num + 1)) 
                ans = Math.Max(ans, values[num] + values[num + 1]);
            
            if (values.ContainsKey(num - 1)) 
                ans = Math.Max(ans, values[num] + values[num - 1]);
            
        }
        return ans;
    }
}

} 