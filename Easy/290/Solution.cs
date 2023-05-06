namespace LeetCode.Problem290{
//290. Word Pattern
//https://leetcode.com/problems/word-pattern/
/*
Given a pattern and a string s, find if s follows the same pattern.

Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
*/
 
  public class Solution {
    public bool WordPattern(string pattern, string s) {
        Dictionary<char,int> dic = new Dictionary<char,int>();
        Dictionary<int,string> words = new Dictionary<int,string>();
        var tempWords = s.Split(' ');
        if (tempWords.Length != pattern.Length)
            return false;
        for (int index = 0; index < pattern.Length; index++)
        {
            var value = pattern[index];
           
           if (dic.ContainsKey(value))
           {
               int place = dic[value];
               if (tempWords[index] != words[place])
                    return false;
                dic[value] = index;
           }
           else
            {
                dic.Add(value,index);
                if (words.ContainsValue(tempWords[index]))
                    return false;
            }

            words.Add(index,tempWords[index]);
        }
        return true;
    }
  }
}
