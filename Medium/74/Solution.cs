using System.Text;

namespace LeetCode.Medium.Problem74{
//74. Search a 2D Matrix
//https://leetcode.com/problems/search-a-2d-matrix/
/*
You are given an m x n integer matrix matrix with the following two properties:

Each row is sorted in non-decreasing order.
The first integer of each row is greater than the last integer of the previous row.
Given an integer target, return true if target is in matrix or false otherwise.

You must write a solution in O(log(m * n)) time complexity.
*/
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int left = 0;
        int right = matrix.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (matrix[mid].Contains(target))
                    return true;

            if (target < matrix[mid][0])
                right = mid - 1;
            else 
                left = mid + 1;
            
        }
        return false;
    }
}
}