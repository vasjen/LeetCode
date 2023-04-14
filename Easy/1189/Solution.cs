namespace LeetCode.Problem1189{
//1189. Maximum Number of Balloons
//https://leetcode.com/problems/maximum-number-of-balloons/
/*
Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.

You can use each character in text at most once. Return the maximum number of instances that can be formed.
*/
  public class Solution {
     public int MaxNumberOfBalloons(string text) {
        Dictionary<char,int> dic = new Dictionary<char,int>();
        string balloon = "balloon";
        int counter = 0;
        for (int i = 0; i < text.Length; i++)
        {   
            var smb = text[i];
            if (balloon.Contains(smb))
            {
            if (!dic.ContainsKey(smb))
                dic.Add(smb,1);
            else
                dic[smb]++;}
             
        }
        foreach (var item in balloon)
            if (!dic.ContainsKey(item))
                return 0;
        dic['o'] /=2;
        dic['l'] /= 2;
        return Math.Min(dic['b'],Math.Min(dic['a'], Math.Min(dic['l'],Math.Min(dic['o'],dic['n']))));
        
    }
}
}