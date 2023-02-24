namespace LeetCode.Problem2451{
//2451. Odd String Difference
//https://leetcode.com/problems/odd-string-difference/
/*
You are given an array of equal-length strings words. Assume that the length of each string is n.

Each string words[i] can be converted into a difference integer array difference[i] of length n - 1 where difference[i][j] = words[i][j+1] - words[i][j] where 0 <= j <= n - 2. Note that the difference between two letters is the difference between their positions in the alphabet i.e. the position of 'a' is 0, 'b' is 1, and 'z' is 25.

For example, for the string "acb", the difference integer array is [2 - 0, 1 - 2] = [2, -1].
All the strings in words have the same difference integer array, except one. You should find that string.

Return the string in words that has different difference integer array.*/
  public class Solution {
    
   
    public string OddString(string[] words) {
        int n = words[0].Count();
        Dictionary<int,int[]> data = new Dictionary<int, int[]>();
        int[] actual = new int[n-1];
        int[] first = new int[n-1];
        for (int i = 0; i<words.Length;i++){
            int[] difference = new int[n-1];
            for (int j=0;j<n-1;j++){
                difference[j]=words[i].ToLower().ElementAt(j+1)-words[i].ToLower().ElementAt(j); 
              }
              data.Add(i,difference);
            }
           
          first=data.Where(p=>p.Key==0).Select(p=>p.Value).FirstOrDefault();
          actual=data.Where(p=>p.Key==1).Select(p=>p.Value).FirstOrDefault();
          
          if (!Enumerable.SequenceEqual(first,actual)){
            
          actual=data.Where(p=>p.Key==2).Select(p=>p.Value).FirstOrDefault();
          if (Enumerable.SequenceEqual(first,actual))
            return words[1];
            return words[0];
          } 
           
           for (int i=2;i<data.Count;i++)
           {
              actual=data.Where(p=>p.Key==i).Select(p=>p.Value).FirstOrDefault();
                if (!Enumerable.SequenceEqual(first,actual))
                return words[i];
           }
            
        return new string("");
    }
    }
} 