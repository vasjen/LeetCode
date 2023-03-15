namespace LeetCode.Problem1957{
//1957. Delete Characters to Make Fancy String
//https://leetcode.com/problems/delete-characters-to-make-fancy-string/
/*
A fancy string is a string where no three consecutive characters are equal.

Given a string s, delete the minimum possible number of characters from s to make it fancy.

Return the final string after the deletion. It can be shown that the answer will always be unique.
*/
    public class Solution {
    public string MakeFancyString(string s) {

        Dictionary<char,List<int>> word = new Dictionary<char, List<int>>();
          
        for (int i = 0;i < s.Length; i++){
            if (word.Where(p => p.Key == s[i]).Any()){
              var temp = word
                        .Where(p => p.Key == s[i])
                        .Select(p=>p.Value)
                        .FirstOrDefault();
              if (temp.Count < 2){
              temp.Add(i);
              word.Remove(s[i]);
              word.Add(s[i],temp);
              }
            }
            else {
              word.Add(s[i],new List<int>() {i});
            }

        }  
        foreach (var item in word)
        {
            System.Console.WriteLine(item.Key);
        }
        var index = word
                    .Where(p => p.Value.Count > 2 )
                    .Select(p => p.Value.Skip(2));
                    
                    
        if (index==default)
            return s;
        System.Console.WriteLine("Indexes for removing");  
        foreach (var item in index)
        {
        foreach (var t in item)
        {
             System.Console.WriteLine($" {t} ");   
        }
        }
        System.Console.WriteLine(" ");
        Queue<char> ans = new Queue<char>();
        for (int i = 0; i < s.Length; i++){
           // if (!index.Contains(i))
             //   ans.Enqueue(s[i]);
        }
        System.Console.WriteLine(" ");

        return new string(ans.ToArray());
    }
}
}