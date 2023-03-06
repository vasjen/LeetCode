namespace LeetCode.Problem2351{
//First Letter to Appear Twice
//https://leetcode.com/problems/first-letter-to-appear-twice/
/*
Given a string s consisting of lowercase English letters, return the first letter to appear twice.
*/
  public class Solution {
    
   
    public char RepeatedCharacter(string s) {
       
        Dictionary<char,List<int>> word = new Dictionary<char, List<int>>();
       
          
        for (int i = 0;i < s.Length; i++){
            if (word.Where(p => p.Key == s[i]).Any()){
              return s[i];
            }
            else {
              word.Add(s[i],new List<int>() {i});
            }

        }  
        
        var index = word
                    .Where(p => p.Value.Count > 1 )
                    .Select(p => p.Value[1])
                    .OrderBy(p => p)
                    .FirstOrDefault();
        
        
        return s[index];
    }
  }
    
} 