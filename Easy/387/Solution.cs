namespace LeetCode.Problem387{
//87. First Unique Character in a String
//https://leetcode.com/problems/first-unique-character-in-a-string/
/*
Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
*/
 public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char,int> dicS = new Dictionary<char,int>();
        for (int i = 0; i < s.Length; i++)
        {
            var value = s[i];
            if (dicS.ContainsKey(value))
            {
                dicS[value] = i;
                continue;
            }
            else
            {
                dicS.Add(value,i);
                var word = s.Substring(i+1);
                if (!word.Contains(value))
                    return i;
            }
        }
        return -1;
    }
}
} 