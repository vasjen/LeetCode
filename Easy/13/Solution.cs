namespace LeetCode.Problem13{
//13. Roman to Integer
//https://leetcode.com/problems/roman-to-integer/
/*
Given a roman numeral, convert it to an integer.
*/
  public class Solution {
    static readonly Dictionary<char,int>? convert = new Dictionary<char, int>()
    {
        {'I',1}, {'V',5}, {'X',10}, {'L',50}, {'C',100}, {'D',500}, {'M',1000}
    };
   public int RomanToInt(string s) {
     int value=convert.Where(p=>p.Key==s.ElementAt(s.Length-1)).Select(p=>p.Value).FirstOrDefault();
        

        for (int i=0;i<s.Length-1;i++){
           bool flag = Increment(s.ElementAt(i), s.ElementAt(i+1));
           value=Sum(flag,convert.Where(p=>p.Key==s.ElementAt(i)).Select(p=>p.Value).FirstOrDefault(),value);
          
        }
        
       int Sum(bool positive, int add, int value){
            if (positive)
            return value+add;
            
            return value-add;


        }

        bool Increment(char current,char next){

          if (current=='C' && next=='M'| next=='D' )
          return false;

           if (current=='X' && next=='L'| next=='C' )
          return false;

            if (current=='I' && next=='V'| next=='X' )
          return false;

          return true;
        }
        
        
        
        return value;
        
   }
  } 
}