namespace LeetCode.Problem205{
//205. Isomorphic Strings
//https://leetcode.com/problems/isomorphic-strings/
/*
Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the order of characters. 
No two characters may map to the same character, but a character may map to itself.

*/

// Definition for a binary tree node.


 
  public class Solution {
   public bool IsIsomorphic(string s, string t) {
        Dictionary<char,int> sdic = new Dictionary<char,int>();
        Dictionary<char,int> tdic = new Dictionary<char,int>();
        for (int i = 0; i < s.Length; i++)
        {
            var svalue = s[i];
            var tvalue = t[i];
            if (!sdic.ContainsKey(svalue))
                {
                    sdic.Add(svalue,i);
                    if (tdic.ContainsKey(tvalue))
                        return false;
                    tdic.Add(tvalue,i);
                }
            else
            {
                if (t[i] != t[sdic[svalue]])
                    return false;
                sdic[svalue] = i;
                tdic[tvalue] = i;
            }
        
        }
        return true;
    }
    }
  }
