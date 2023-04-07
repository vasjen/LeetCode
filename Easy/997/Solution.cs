namespace LeetCode.Problem997{
//997. Find the Town Judge
//https://leetcode.com/problems/find-the-town-judge/
/*
In a town, there are n people labeled from 1 to n. There is a rumor that one of these people is secretly the town judge.

If the town judge exists, then:

The town judge trusts nobody.
Everybody (except for the town judge) trusts the town judge.
There is exactly one person that satisfies properties 1 and 2.
You are given an array trust where trust[i] = [ai, bi] representing that the person labeled ai trusts the person labeled bi. 
If a trust relationship does not exist in trust array, then such a trust relationship does not exist.

Return the label of the town judge if the town judge exists and can be identified, or return -1 otherwise.


*/

  public class Solution {
    
    public int FindJudge(int n, int[][] trust) {
      Dictionary<int,int> trusted = new Dictionary<int,int>();
      var releation = new HashSet<int[]>(trust);
      int citizen = n;
        var judge = 0;
      foreach (var item in trust)
      {
        if (!trusted.ContainsKey(item[0]))
          trusted.Add(item[0],item[1]);
      }
      if (trusted.Count == n - 1)
      {
        while (citizen >= 1)
        {
          if (!trusted.ContainsKey(citizen))
            judge = citizen;
          citizen--;
        }
        for (int i = 1; i <= n; i++)
        {
          if (i == judge)
            continue;
          if (!releation.Where(p => p[0] == i).Select(p => p[1]).Contains(judge))   
            return -1;
        }
        return judge;
      }
      
    
      
     
      return -1;
    }
    } 
}