namespace LeetCode.Problem326{
//326. Power of Three
//https://leetcode.com/problems/power-of-three/
/*
Given an integer n, return true if it is a power of three. Otherwise, return false.

An integer n is a power of three, if there exists an integer x such that n == 3x.
*/
  public class Solution {
    public bool IsPowerOfThree(int n) {
      if (n==0 || n==-1)
        return false;
      
      double power= Math.Log10(n)/Math.Log10(3);
    return power == Math.Round(power);
    }
}
} 