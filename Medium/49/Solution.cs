using System.Text;

namespace LeetCode.Medium.Problem49{
//49. Group Anagrams
//https://leetcode.com/problems/group-anagrams/
/*
Given an array of strings strs, group the anagrams together. You can return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
*/
public class Solution {
public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dic = new Dictionary<string,List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            var word = new string(strs[i].OrderBy(p => p).ToArray());
            if (dic.ContainsKey(word))
                dic[word].Add(strs[i]);
            else
                dic.Add(word,new List<string>() {strs[i]});
        }
        string[][] ans = new string[dic.Count][];
        int index = 0;
        foreach (var item in dic)
        {
            ans[index] = item.Value.ToArray();
            index++;
        }

        return ans;
    }
}
}