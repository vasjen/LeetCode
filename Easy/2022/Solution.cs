using System.Text;

namespace LeetCode.Problem2022{
//2022. Convert 1D Array Into 2D Array 
//https://leetcode.com/problems/convert-1d-array-into-2d-array/
/*
You are given a 0-indexed 1-dimensional (1D) integer array original, and two integers, m and n. 
You are tasked with creating a 2-dimensional (2D) array with  m rows and n columns using all the elements from original.

The elements from indices 0 to n - 1 (inclusive) of original should form the first row of the constructed 2D array, 
the elements from indices n to 2 * n - 1 (inclusive) should form the second row of the constructed 2D array, and so on.

Return an m x n 2D array constructed according to the above procedure, or an empty 2D array if it is impossible.
*/
  public class Solution {
   public int[][] Construct2DArray(int[] original, int m, int n) {
        if (m * n < original.Length || n > original.Length / m)
          return  new int[0][];
        
        int level = 0;
        int[][] ans = new int[m][];
        for (int i = 0; i < ans.Length; i++)
        {
          List<int> row = new List<int>();
          for (int j = 0; j <= n-1; j++)
          {
            row.Add(original[n * level + j]);
            
          }
          ans[i] = row.ToArray();
          level++;
        }
        return ans;
    }
}
} 