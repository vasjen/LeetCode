namespace LeetCode.Problem1941{
//1941. Check if All Characters Have Equal Number of Occurrences
//https://leetcode.com/problems/check-if-all-characters-have-equal-number-of-occurrences/
/*
Given a string s, return true if s is a good string, or false otherwise.

A string s is good if all the characters that appear in s have the same number of occurrences (i.e., the same frequency).
*/
    public class Solution { public bool AreOccurrencesEqual(string s) {
       Dictionary<char,int> times = new Dictionary<char,int>();
       for (int i = 0; i < s.Length; i++)
       {    
           char tmp = s[i];
           if (times.ContainsKey(tmp))
            times[tmp]++;
            else
                times.Add(tmp,1);
       } 
       HashSet<int> set = new HashSet<int>(times.Values);
       return set.Count == 1;
    }
}
}