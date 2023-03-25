namespace LeetCode.Problem2144{
//2144. Minimum Cost of Buying Candies With Discount
//https://leetcode.com/problems/minimum-cost-of-buying-candies-with-discount/
/*
A shop is selling candies at a discount. For every two candies sold, the shop gives a third candy for free.

The customer can choose any candy to take away for free as long as the cost of the chosen candy is less than or equal 
to the minimum cost of the two candies bought.

For example, if there are 4 candies with costs 1, 2, 3, and 4, and the customer buys candies with costs 2 and 3, 
they can take the candy with cost 1 for free, but not the candy with cost 4.
Given a 0-indexed integer array cost, where cost[i] denotes the cost of the ith candy, return the minimum cost of buying all the candies.
*/
  public class Solution {
    public int MinimumCost(int[] cost) {
        if (cost.Length < 3)
          return cost.Sum();
        int totalCost = 0;
       
        List<int> candies = cost.OrderByDescending(p => p).ToList();
        
        while (candies.Count > 2)
        {
          var doubleCandies = candies.Take(2);
          int min = doubleCandies.Min();
          totalCost += doubleCandies.Sum();
          candies.RemoveRange(0,2);

          if (candies.FirstOrDefault() <= min)
          {
            candies.RemoveAt(0); 
          }
        }

        return totalCost+candies.Sum();
    }
}
} 