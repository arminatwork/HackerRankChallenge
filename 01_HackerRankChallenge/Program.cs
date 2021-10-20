//Complete the function solveMeFirst to compute the sum of two integers.

//Example
//a = 7
//b = 3

//Return 10.

//Function Description

//Complete the solveMeFirst function in the editor below.

//solveMeFirst has the following parameters:

//int a: the first value
//int b: the second value
//Returns
//- int: the sum of a and b

int val1 = Convert.ToInt32(Console.ReadLine());
int val2 = Convert.ToInt32(Console.ReadLine());
int sum = Result.solveMeFirst(val1, val2);
Console.WriteLine(sum);


class Result
{
    public static int solveMeFirst(int a, int b)
    {
        return a + b;
    }

}