namespace LeetCode.Problem1103{
//1103. Distribute Candies to People
//https://leetcode.com/problems/distribute-candies-to-people/
/*
We distribute some number of candies, to a row of n = num_people people in the following way:

We then give 1 candy to the first person, 2 candies to the second person, and so on until we give n candies to the last person.

Then, we go back to the start of the row, giving n + 1 candies to the first person, n + 2 candies 
to the second person, and so on until we give 2 * n candies to the last person.

This process repeats (with us giving one more candy each time, and moving to the start of the row 
after we reach the end) until we run out of candies.  The last person will receive all of our remaining 
candies (not necessarily one more than the previous gift).

Return an array (of length num_people and sum candies) that represents the final distribution of candies.


*/
  public class Solution {
    public int[] DistributeCandies(int candies, int num_people) {
      
        int counter = 0;
        List<int> CandyList = new();
        while (candies - counter > 0)
          {
            counter++;
            candies -= counter;
            CandyList.Add(counter);
          }
        int stopIndex = counter % num_people;
        var ans = CandyList
                  .Select((p,index)=>
                  new {
                   filter = index % num_people, value = p
                  })
                  .GroupBy(p=>p.filter)
                  .ToList();
         
        int[] res = new int[num_people];
        for (int i = 0; i < ans.Count; i++)
        {
          res[i] = ans
                  .ElementAt(i)
                  .Sum(p=>p.value);
        }
        if (candies != 0)
          res[stopIndex] += candies;

        

    return res;    
    }
}
} 