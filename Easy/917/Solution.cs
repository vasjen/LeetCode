using System.Text;

namespace LeetCode.Problem917{
//917. Reverse Only Letters
//https://leetcode.com/problems/reverse-only-letters/
/*
Given a string s, reverse the string according to the following rules:

All the characters that are not English letters remain in the same position.
All the English letters (lowercase or uppercase) should be reversed.
Return s after reversing it.


*/
  public class Solution {
   public string ReverseOnlyLetters(string s) {
        StringBuilder sb = new StringBuilder();
        int left = 0;
        int right = s.Length-1;
        while (left < s.Length)
        {   
            while (right >= 0 && !(s[right] >= 65 && s[right] <= 90) & !(s[right] >= 97 && s[right] <= 122))
                right--;

            if (s[left] >= 65 && s[left] <= 90 || s[left] >= 97 && s[left] <= 122)
                {
                    sb.Append(s[right]);
                    right--;
                }
            else
             sb.Append(s[left]);
            left++;
    }   
    return sb.ToString();
 }
} 
}