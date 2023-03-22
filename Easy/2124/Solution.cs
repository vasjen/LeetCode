namespace LeetCode.Problem2124{
//2124. Check if All A's Appears Before All B's
//https://leetcode.com/problems/check-if-all-as-appears-before-all-bs/
/*
Given a string s consisting of only the characters 'a' and 'b', 
return true if every 'a' appears before every 'b' in the string. Otherwise, return false.
*/
  public class Solution {
    public bool CheckString(string s) {
        if (!s.Contains('a') && s.Contains('b')
            ||
            !s.Contains('b') && s.Contains('a'))
          return true;

          if (s.Length == 1)
            return true;

        return (s.LastIndexOf('a') < s.IndexOf('b'));
    }
}
} 