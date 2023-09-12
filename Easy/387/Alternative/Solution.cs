namespace LeetCode.Problem387.Alternative{
//87. First Unique Character in a String
//https://leetcode.com/problems/first-unique-character-in-a-string/
/*
Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
*/
 public class Solution {
    public int FirstUniqChar(string s) {
        for (int i = 0; i < s.Length; i++)
        {
            var value = s[i];
            if (s.IndexOf(value) == s.LastIndexOf(value) && s.Sum(p => p == value) > 1)
                return i;
        }
        return -1;
    }
}
} 