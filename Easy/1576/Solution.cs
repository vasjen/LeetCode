 using System.Text;

namespace LeetCode.Problem1576{
//1576. Replace All ?'s to Avoid Consecutive Repeating Characters
//https://leetcode.com/problems/replace-all-s-to-avoid-consecutive-repeating-characters/
/*
Given a string s containing only lowercase English letters and the '?' character, convert all the '?' characters 
into lowercase letters such that the final string does not contain any consecutive repeating characters. 
You cannot modify the non '?' characters.

It is guaranteed that there are no consecutive repeating characters in the given string except for '?'.

Return the final string after all the conversions (possibly zero) have been made. 
If there is more than one solution, return any of them. It can be shown that an answer is always possible with the given constraints.
*/
  public class Solution {
    
   
    public string ToLowerCase(string s) {
        StringBuilder ans = new StringBuilder();
        foreach (var item in s)
        {
            if (item >= 65 && item <= 90)
                ans.Append((char)(item + 32));
            else ans.Append(item);
        }

        return ans.ToString(); 
    }
    public string ModifyString(string s) {
     StringBuilder ans = new StringBuilder();
      var hz = ' ';
      int val = 0;
      for (int i = 0; i < s.Length; i++)
      {
        if (s[i] == '?')
        {
          char prev = i > 0 ? ans[i - 1] :  ' ';
          char next = i < s.Length-1 ? s[i + 1] :  ' ';
          val = 0;
          do
          {
            hz = Convert.ToChar(97+val);
            val++;

          }
          while(hz == prev || hz == next);
         
              ans.Append(hz);
        }
        else
          ans.Append(s[i]);
        
      }

      return ans.ToString();
    }
  }
} 