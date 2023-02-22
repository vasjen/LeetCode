namespace CLeetCode.Problem1979{
//https://leetcode.com/problems/find-greatest-common-divisor-of-array/
/*
Given an integer array nums, return the greatest common divisor of the smallest number 
and largest number in nums.

The greatest common divisor of two numbers is the largest positive integer that evenly divides both numbers.
*/
  public class Solution {
    public int FindGCD(int[] nums) {
      int GCD = 1;
      int max = nums.Max();
      int min = nums.Min();
        for (int i=max;i>1; i--)
        {
          if (max % i == 0 && min % i == 0)
          {
            GCD=i;
            break;
          }
        }
        return GCD;
    }
}
} 