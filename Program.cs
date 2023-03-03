// See https://aka.ms/new-console-template for more information

//

var sol = new LeetCode.Problem326.Solution();
var tsk1 = 27;
var ans1 = sol.IsPowerOfThree(tsk1);
System.Console.WriteLine("Number {0} => Ans {1}",tsk1,ans1);

var tsk2 = 0;
var ans2 = sol.IsPowerOfThree(tsk2);
System.Console.WriteLine("Number {0} => Ans {1}",tsk2,ans2);

var tsk3 = -1;
var ans3 = sol.IsPowerOfThree(tsk3);
System.Console.WriteLine("Number {0} => Ans {1}",tsk3,ans3);

var tsk4 = 1;
var ans4 = sol.IsPowerOfThree(tsk4);
System.Console.WriteLine("Number {0} => Ans {1}",tsk4,ans4);

