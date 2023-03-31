namespace LeetCode.Problem1408{
//1408. String Matching in an Array
//https://leetcode.com/problems/string-matching-in-an-array/
/*
Given an array of string words, return all strings in words that is a substring of another word. You can return the answer in any order.

A substring is a contiguous sequence of characters within a string
*/
  public class Solution {
  public IList<string> StringMatching(string[] words) {
        
        var wordsNew = words.ToList();
        var sorted = words.OrderBy(p => p.Length).ToList();
        for (int i = 0; i < sorted.Count; i++)
        {
          if (wordsNew.Where(p => p.Contains(sorted[i])).Count() < 2 )
          {
            wordsNew.Remove(sorted[i]);
          }

        }

        return wordsNew;
    }

}
}