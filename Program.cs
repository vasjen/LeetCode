
var sol = new LeetCode.Problem929.Solution();
var emails0 = new string[] {"test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"};
var ans0 = sol.NumUniqueEmails(emails0);
System.Console.WriteLine("Asnwer is {0}", ans0);

var emails1 = new string[] {"a@leetcode.com","b@leetcode.com","c@leetcode.com"};
var ans1 = sol.NumUniqueEmails(emails1);
System.Console.WriteLine("Asnwer is {0}", ans1);



