
namespace LeetCode.Problem976{
//976. Largest Perimeter Triangle
//https://leetcode.com/problems/largest-perimeter-triangle/
/*
Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. 
If it is impossible to form any triangle of a non-zero area, return 0.


*/
  public class Solution {
    public int LargestPerimeter(int[] nums) {
        var sides = nums.OrderByDescending(p => p).ToList();
        int first = sides[0];
        int second = sides[1];
        int third = sides[2];
        if (first < second + third)
              return first + second + third;
        for (int i = 3; i < sides.Count; i++)
        {
          first = second;
          second = third;
          third = sides[i];
          if (first < second + third)
            return first + second + third;

        }

       

      return 0;
    }
    
}
} 