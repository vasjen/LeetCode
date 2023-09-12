namespace LeetCode.Problem1047{
//1047. Remove All Adjacent Duplicates In String
//https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string/
/*
You are given a string s consisting of lowercase English letters. 
A duplicate removal consists of choosing two adjacent and equal letters and removing them.

We repeatedly make duplicate removals on s until we no longer can.

Return the final string after all such duplicate removals have been made. It can be proven that the answer is unique.
*/

public class Solution {
    public string RemoveDuplicates(string s) {
        Stack<char> word = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (word.Count > 0)
            {
                var last = word.Peek();
                if (last == s[i])
                    word.Pop();
                else
                    word.Push(s[i]);
            }
            else
                word.Push(s[i]);
        }
        return new string(word.Reverse().ToArray());
    }
}
}