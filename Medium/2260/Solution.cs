namespace LeetCode.Medium.Problem2260{
//2260. Minimum Consecutive Cards to Pick Up
//https://leetcode.com/problems/minimum-consecutive-cards-to-pick-up/
/*
You are given an integer array cards where cards[i] represents the value of the ith card. 
A pair of cards are matching if the cards have the same value.

Return the minimum number of consecutive cards you have to pick up to have a pair of matching cards among the picked cards.
 If it is impossible to have matching cards, return -1.
*/
public class Solution {
   public int MinimumCardPickup(int[] cards) {
     int ans = int.MaxValue;
     Dictionary<int,int> dic = new Dictionary<int,int>();
     for (int i = 0; i < cards.Length; i++)
     {
        int value = cards[i];
        if (dic.ContainsKey(value))
            {
                ans = Math.Min(ans, i - dic[value] + 1);
                dic[value] = i;
            
            }
        else
            dic.Add(value,i);
   
     }      
     return ans == int.MaxValue ? -1 : ans;
    }
    }
}
