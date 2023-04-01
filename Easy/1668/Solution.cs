 using System.Text;

namespace LeetCode.Problem1668{
//1668. Maximum Repeating Substring
//https://leetcode.com/problems/maximum-repeating-substring/
/*
For a string sequence, a string word is k-repeating if word concatenated k times is a substring of sequence. 
The word's maximum k-repeating value is the highest value k where word is k-repeating in sequence. 
If word is not a substring of sequence, word's maximum k-repeating value is 0.

Given strings sequence and word, return the maximum k-repeating value of word in sequence.
*/
  public class Solution {
    
   
    public int MaxRepeating(string sequence, string word) {
        StringBuilder sb = new StringBuilder();
        
        while (sequence.Contains(sb.ToString()))
        {
        sb.Append(word);
        }
        return (sb.Length - word.Length) / word.Length;
    }
    
  }
} 