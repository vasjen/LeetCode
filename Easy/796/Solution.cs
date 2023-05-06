using System.Text;

namespace LeetCode.Problem796{
//796. Rotate String
//https://leetcode.com/problems/rotate-string/
/*
Given two strings s and goal, return true if and only if s can become goal after some number of shifts on s.

A shift on s consists of moving the leftmost character of s to the rightmost position.

For example, if s = "abcde", then it will be "bcdea" after one shift.
*/
  public class Solution {
     public bool RotateString(string s, string goal) {
        StringBuilder sb = new StringBuilder(s);
        for (int i = 0; i < s.Length; i++)
        {
            var tempSym = sb[0];
            sb.Remove(0,1);
            sb.Append(tempSym);
            if (sb.ToString() == goal)
                return true;
        }
        return false;
    }
}
}