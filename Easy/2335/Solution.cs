namespace LeetCode.Problem2335{
//2335. Minimum Amount of Time to Fill Cups
//https://leetcode.com/problems/minimum-amount-of-time-to-fill-cups/
/*
You have a water dispenser that can dispense cold, warm, and hot water. Every second, you can either fill up 2 cups 
with different types of water, or 1 cup of any type of water.

You are given a 0-indexed integer array amount of length 3 where amount[0], amount[1], and amount[2] denote 
the number of cold, warm, and hot water cups you need to fill respectively. Return the minimum number of seconds needed to fill up all the cups.
*/
  public class Solution {
    public int FillCups(int[] amount) {
      int count = 0;
      
      List<int> AllNumbers = new List<int>();
      AllNumbers.AddRange(amount.Where(p => p != 0).OrderByDescending(p=>p));



      while (AllNumbers.Count > 1)
      {
        int valueFirst = AllNumbers.FirstOrDefault();
        AllNumbers.Remove(valueFirst);
        count++;
        valueFirst--;
        int valueSecond = AllNumbers.FirstOrDefault();
        AllNumbers.Remove(valueSecond);
        valueSecond--;

        if (valueFirst > 0)
          AllNumbers.Add(valueFirst);  
         if (valueSecond > 0)
          AllNumbers.Add(valueSecond);

          AllNumbers = AllNumbers
                      .OrderByDescending(p=>p)
                      .ToList(); 
      }
       if (AllNumbers.Any() == false)
        return count;
      else
        return count + AllNumbers.FirstOrDefault();
   } 
}
} 