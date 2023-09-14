using System.Text;

namespace LeetCode.Problem125.Alternative{
//125. Valid Palindrome
//https://leetcode.com/problems/valid-palindrome/
/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters 
and removing all non-alphanumeric characters, 
it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.


*/
 
  public class Solution {
    public bool IsPalindrome(string s) {

      StringBuilder sb = new();
       foreach (var item in s)
       {
          if (System.Char.IsLetterOrDigit(item))
            sb.Append(Char.ToLower(item));
       }
       int left = 0;
       int right = sb.Length - 1;
       while (right >= left)
       {
          if (sb[left] != sb[right])
            return false;

          left++;
          right--;
       }
       return true;    
     
    }
    }
  }
