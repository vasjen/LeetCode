namespace LeetCode.Problem125{
//125. Valid Palindrome
//https://leetcode.com/problems/valid-palindrome/
/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, 
it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.


*/
 
  public class Solution {
      public bool IsPalindrome(string s) {
        
        Queue<char> forward = new Queue<char>();
        Stack<char> backward = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
            {
                forward.Enqueue(char.ToLower(s[i]));
                backward.Push(char.ToLower(s[i]));
            }
        }
        return forward.SequenceEqual(backward);
    }
    }
  }
