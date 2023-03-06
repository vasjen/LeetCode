namespace LeetCode.Problem1539{
//1422. Kth Missing Positive Number
//https://leetcode.com/problems/kth-missing-positive-number/
/*
Given an array arr of positive integers sorted in a strictly increasing order, and an integer k.
Return the kth positive integer that is missing from this array.

*/
  public class Solution {
     
     public int FindKthPositive(int[] arr, int k) {
        int index = 1;
        int countOfMissed = arr.LastOrDefault() - arr.Length;
        if (countOfMissed == 0) 
          return k + arr.LastOrDefault();
        
        if (k > countOfMissed ) 
            return arr.LastOrDefault() + (k - countOfMissed); 
          
        while (k > 0)
            {  
              var t = arr.Select(p=>p).Where(p=> p == index).Any();
              if (t == false) { 
                  k--;
                }
                index++;
            }
       
      return index-1;
}
} 
}