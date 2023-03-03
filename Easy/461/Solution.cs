namespace LeetCode.Problem461{
//461. Hamming Distance
//https://leetcode.com/problems/hamming-distance/
/*
The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

Given two integers x and y, return the Hamming distance between them.
*/
  public class Solution {
    public int HammingDistance(int x, int y) {
      
        var res = x ^ y;
        int count=0;
         int n = x ^ y;
        while (n != 0) {
            n = n & (n - 1);
            count++;
        }
        
        return count;
    }
}
} 