namespace LeetCode.Problem2351.Alternative{
//First Letter to Appear Twice
//https://leetcode.com/problems/first-letter-to-appear-twice/
/*
Given a string s consisting of lowercase English letters, return the first letter to appear twice.
*/
  public class Solution {
    
   
    public char RepeatedCharacter(string s) {
       
        List<char> word = new List<char>();
        byte i = 0;
        
        while (!word.Where(p => p == s[i]).Any()){
          word.Add(s[i]);
          i++;
        }
        return s[i];

    }
  }
    
} 