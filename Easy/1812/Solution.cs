namespace LeetCode.Problem1812{
//1886. Determine Color of a Chessboard Square
//https://leetcode.com/problems/determine-color-of-a-chessboard-square/
/*
You are given coordinates, a string that represents the coordinates of a square of the chessboard. 
Return true if the square is white, and false if the square is black.

*/
  public class Solution {
     
     public bool SquareIsWhite(string coordinates) {
      
        return !(
            (Convert.ToInt32(coordinates[0]) % 2 == 0 
            && Convert.ToInt32(coordinates[1]) % 2 == 0) 
          ^ 
            (Convert.ToInt32(coordinates[0]) % 2 == 1 
            && Convert.ToInt32(coordinates[1]) % 2 == 1));
    }
  } 
}