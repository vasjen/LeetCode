using System.Text;

namespace LeetCode.Problem1544{
//1544. Make The String Great
//https://leetcode.com/problems/make-the-string-great/
/*
Given a string s of lower and upper case English letters.

A good string is a string which doesn't have two adjacent characters s[i] and s[i + 1] where:

0 <= i <= s.length - 2
s[i] is a lower-case letter and s[i + 1] is the same letter but in upper-case or vice-versa.
To make the string good, you can choose two adjacent characters that make the string bad and remove them. 
You can keep doing this until the string becomes good.

Return the string after making it good. The answer is guaranteed to be unique under the given constraints.

Notice that an empty string is also good.

*/
  public class Solution {
     
      public string MakeGood(string s) {
      
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
          var prev = sb.Length  > 0 ? sb[sb.Length - 1] : ' ';
          var next = i < s.Length - 2 ? s[i + 1] : ' ';
          if (s[i] >= 65 && s[i] <= 90)
          {
            if (s[i] + 32 == prev)
              sb.Remove(sb.Length - 1,1);
            else
            {
              if (s[i] + 32 == next)
                i++;
              else
                sb.Append(s[i]);
            }
          }
          else
          {
            if (prev + 32 == s[i] )
              sb.Remove(sb.Length - 1,1);
            else  
              sb.Append(s[i]);
          }
           
        }  
      return sb.ToString();  
    }
  } 
}