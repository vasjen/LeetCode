namespace LeetCode.Problem1103.ALternative{
public class Solution {
    public int[] DistributeCandies(int candies, int num_people) {
      
        int counter = 0;
        int index = 0;
        int[] res = new int[num_people];
        
        while (candies - counter > 0)
            {
              index = counter % num_people;
              counter++;
              candies -= counter;
              res[index] += counter;
            }
            
        if (candies != 0)
          res[counter % num_people] += candies;

     return res;    
    }
}
}