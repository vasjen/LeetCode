using System.Text;

namespace LeetCode.Problem929{
//929. Unique Email Addresses
//https://leetcode.com/problems/unique-email-addresses/
/*
Every valid email consists of a local name and a domain name, separated by the '@' sign. 
Besides lowercase letters, the email may contain one or more '.' or '+'.

For example, in "alice@leetcode.com", "alice" is the local name, and "leetcode.com" is the domain name.
If you add periods '.' between some characters in the local name part of an email address, mail sent there 
will be forwarded to the same address without dots in the local name. Note that this rule does not apply to domain names.

For example, "alice.z@leetcode.com" and "alicez@leetcode.com" forward to the same email address.
If you add a plus '+' in the local name, everything after the first plus sign will be ignored. This allows 
certain emails to be filtered. Note that this rule does not apply to domain names.

For example, "m.y+name@email.com" will be forwarded to "my@email.com".
It is possible to use both of these rules at the same time.

Given an array of strings emails where we send one email to each emails[i], return the number of different 
addresses that actually receive mails.


*/
  public class Solution {
    public int NumUniqueEmails(string[] emails) {
        
        List<string> emailsList = new List<string>();
        for (int i = 0; i < emails.Length; i++)
        {
          var email = emails[i].Split('@');
          if (email[0].Contains('+'))
            email[0] = email[0].Remove(email[0].IndexOf('+'));
          if (email[0].Contains('.'))
            email[0] = email[0].Replace(".","");
          if (!emailsList.Any(p => p == email[0]+"@"+email[1]))
            emailsList.Add(email[0]+"@"+email[1]);
        }

        return emailsList.Count;

    }
}
} 