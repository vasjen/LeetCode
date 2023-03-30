namespace LeetCode.Problem1089{
//1089. Duplicate Zeros
//https://leetcode.com/problems/duplicate-zeros/
/*
Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.

Note that elements beyond the length of the original array are not written. Do the above modifications to the input array 
in place and do not return anything.

*/
  public class Solution {
     public void DuplicateZeros(int[] arr) {

      Queue<int> values = new Queue<int>(arr);
      int[] anss = new int [arr.Length];
      for (int i = 0; i < anss.Length; i++)
      {
        anss[i] = values.Dequeue();
        if (anss[i] == 0 && i < anss.Length-1)
        {
          anss[i + 1] = 0;
          i++;
        }
      }  
      Array.Copy(anss,arr,arr.Length); 
    }
  }
}
 