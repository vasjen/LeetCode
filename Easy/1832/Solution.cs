namespace LeetCode.Problem1832{
//1832. Check if the Sentence Is Pangram
//https://leetcode.com/problems/check-if-the-sentence-is-pangram/
/*
A pangram is a sentence where every letter of the English alphabet appears at least once.

Given a string sentence containing only lowercase English letters, return true if sentence is a pangram, or false otherwise.



*/
  public class Solution {
     
      public bool CheckIfPangram(string sentence) {
        Dictionary<char,int> word = new Dictionary<char,int>();  
        
        for (int i = 0; i < sentence.Length; i++)
        {
            var smb = sentence[i];
            if (word.ContainsKey(smb))
                word[smb]++;
            else
                word.Add(smb,1);
        }
        return word.Count == 26;
    }
  } 
}