
var sol = new LeetCode.Problem1886.Solution();
var mat0 = new int[2][];
    mat0[0] = new int[] {0,1};
    mat0[1] = new int[] {1,0};
var target0 = new int[2][]; 
    target0[0] = new int[] {1,0};
    target0[1] = new int[] {0,1};
var ans0 = sol.FindRotation(mat0,target0);
System.Console.WriteLine("Answer is : {0}",ans0);

int[][] mat1 = {
    new int[] {0,1},
    new int[] {1,1}
};
int[][] target1 = {
    new int[] {1,0},
    new int[] {0,1}
};
var ans1 = sol.FindRotation(mat1,target1);
System.Console.WriteLine("Answer is : {0}",ans1);

int[][] mat2 = {
    new int[] {0,0,0},
    new int[] {0,1,0},
    new int[] {1,1,1}
};
int[][] target2 = {
    new int[] {1,1,1},
    new int[] {0,1,0},
    new int[] {0,0,0}
};
var ans2 = sol.FindRotation(mat2,target2);
System.Console.WriteLine("Answer is : {0}",ans2);

int[][] mat3 = {
    new int[] {1,1},
    new int[] {0,1},
    
};
int[][] target3 = {
    new int[] {1,1},
    new int[] {1,0},
    
};
var ans3 = sol.FindRotation(mat3,target3);
System.Console.WriteLine("Answer is : {0}",ans3);