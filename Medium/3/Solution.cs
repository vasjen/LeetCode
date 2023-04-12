namespace LeetCode.Medium.Problem3{
//3. Longest Substring Without Repeating Characters
//https://leetcode.com/problems/longest-substring-without-repeating-characters/
/*
Given a string s, find the length of the longest 
substring
 without repeating characters.
*/
public class Solution {
   public int LengthOfLongestSubstring(string s) {
        int ans = 0;
        int left = 0;
        Dictionary<char,int> dic = new Dictionary<char,int>();
        
        for (int right = 0; right < s.Length; right++)
        {   
            if (dic.ContainsKey(s[right]))
            {
                left = Math.Max(dic[s[right]] + 1, left);
                dic[s[right]] = right;
            } 
            else
                dic.Add(s[right],right);
           
            ans = Math.Max(ans, right - left +1);
        }
        return ans;
    }
}
}