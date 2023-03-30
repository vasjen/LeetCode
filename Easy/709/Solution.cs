using System.Text;

namespace LeetCode.Problem709{
//709. To Lower Case
//https://leetcode.com/problems/to-lower-case/
/*
Given a string s, return the string after replacing every uppercase letter with the same lowercase letter.
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
  }
} 