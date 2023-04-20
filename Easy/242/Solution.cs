namespace LeetCode.Problem242{
//242. Valid Anagram
//https://leetcode.com/problems/valid-anagram/
/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
typically using all the original letters exactly once.
*/

// Definition for a binary tree node.
  public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;
        else
        {
            Dictionary<char,int> sDic = new Dictionary<char,int>();
            Dictionary<char,int> tDic = new Dictionary<char,int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (sDic.ContainsKey(s[i]))
                    sDic[s[i]]++;
                else
                    sDic.Add(s[i],1);

                if (tDic.ContainsKey(t[i]))
                    tDic[t[i]]++;
                else
                    tDic.Add(t[i],1);
            }
            foreach (var item in sDic)
            {
                if (!tDic.ContainsKey(item.Key) || item.Value != tDic[item.Key])
                    return false;
            }
        }
        return true;
    }
    }
  }
