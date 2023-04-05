namespace LeetCode.Problem2413{
//2413. Smallest Even Multiple
//https://leetcode.com/problems/smallest-even-multiple/
/*
Given a positive integer n, return the smallest positive integer that is a multiple of both 2 and n.
*/
  public class Solution {
    public int SmallestEvenMultiple(int n) {
        while (n % 2 !=0)
          n += n;
        return n;
    }
}
} 