namespace LeetCode.Problem414{
//414. Third Maximum Number
//https://leetcode.com/problems/third-maximum-number/
/*
Given an integer array nums, return the third distinct maximum number in this array. 
If the third maximum does not exist, return the maximum number.
*/
  public class Solution {
    public int ThirdMax(int[] nums) {
        var order = nums.OrderByDescending(p =>p).GroupBy(p => p).ToList();
        if (order.Count >= 3)
          return order[2].FirstOrDefault();
        
        return order[0].FirstOrDefault();

    }
}
} 