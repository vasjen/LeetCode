namespace CLeetCode.Problem9{
//https://leetcode.com/problems/palindrome-number/
public class Solution {
    public bool IsPalindrome(int x) {
    int reverse=x%10;
    int newX=x;
    
    if (x<0) 
    return false;
    
    if (x>=0 && x<10)
    return true;

    while (newX/10>0)
       {
         newX=newX/10;
         reverse=reverse*10+(newX % 10);
       }
       
        return reverse==x;
    }

}
}