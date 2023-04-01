 using System.Text;

namespace LeetCode.Problem1662{
//1662. Check If Two String Arrays are Equivalent
//https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
/*
Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.

A string is represented by an array if the array elements concatenated in order forms the string.
*/
  public class Solution {
    
   
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        StringBuilder w1 = new StringBuilder();
        StringBuilder w2 = new StringBuilder();
       
          foreach (var item in word1)
          {
            w1.Append(item);
          }
           foreach (var item in word2)
          {
            w2.Append(item);
          }
          return w1.Equals(w2);
        
    }
    
  }
} 