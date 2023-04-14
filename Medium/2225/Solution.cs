namespace LeetCode.Medium.Problem2225{
//2225. Find Players With Zero or One Losses
//https://leetcode.com/problems/find-players-with-zero-or-one-losses/
/*
You are given an integer array matches where matches[i] = [winneri, loseri] indicates that the player winneri defeated player loseri in a match.

Return a list answer of size 2 where:

answer[0] is a list of all players that have not lost any matches.
answer[1] is a list of all players that have lost exactly one match.
The values in the two lists should be returned in increasing order.

Note:

You should only consider the players that have played at least one match.
The testcases will be generated such that no two matches will have the same outcome.
*/
public class Solution {
        public IList<IList<int>> FindWinners(int[][] matches) {
            HashSet<int> winners = new HashSet<int>();
            Dictionary<int,int> loosers = new Dictionary<int,int>();
            
            for (int i = 0; i < matches.Length; i++)
            {
                
                if (loosers.ContainsKey(matches[i][1]))
                    loosers[matches[i][1]]++;
                else
                    loosers.Add(matches[i][1],1);
                if (!loosers.ContainsKey(matches[i][0]))
                    winners.Add(matches[i][0]);
                if (winners.Contains(matches[i][1]))
                    winners.Remove(matches[i][1]);
                
            }
            int[][] ans = new int[2][];
            ans[0] = winners.OrderBy(p => p).ToArray();
            ans[1] = loosers.Where(p => p.Value == 1).Select(p => p.Key).OrderBy(p => p).ToArray();
            return ans;
    }
 }
}