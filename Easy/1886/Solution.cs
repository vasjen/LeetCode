namespace LeetCode.Problem1886{
//1886. Determine Whether Matrix Can Be Obtained By Rotation
//https://leetcode.com/problems/determine-whether-matrix-can-be-obtained-by-rotation/
/*
Given two n x n binary matrices mat and target, return true if it is possible to make mat equal to target by rotating 
mat in 90-degree increments, or false otherwise.

*/
  public class Solution {
     
     public bool FindRotation(int[][] mat, int[][] target) {
          
        int[][] comparing = new int[mat.Length][];
        for (int steps = 0; steps < 4; steps++)
        {
          int equals = 0;
          for (int i = 0; i < mat.Length; i++)
          {
            comparing[i] = mat.Select(p => p[i]).Reverse().ToArray();
            if (comparing[i].SequenceEqual(target[i]))
            {
              equals++;
            }
          }
          if (equals == comparing.Length) return true;
          Array.Copy(comparing,mat,mat.Length);
        }
        return false;
  
     

    }
  } 
}