//In this challenge, you are required to calculate and print the sum of the elements in an array, keeping in mind that some of those integers may be quite large.

//Function Description

//Complete the aVeryBigSum function in the editor below.It must return the sum of all array elements.

//aVeryBigSum has the following parameter(s):

//int ar[n]: an array of integers .
//Return

//long: the sum of all array elements
//Input Format

//The first line of the input consists of an integer n.
//The next line contains n space-separated integers contained in the array.

//Output Format

//Return the integer sum of the elements in the array.

int arCount = Convert.ToInt32(Console.ReadLine().Trim());

List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

long result = Result.aVeryBigSum(ar);

Console.WriteLine(result);

class Result
{
    public static long aVeryBigSum(List<long> ar)
    {
        //long sum = 0;

        //foreach (var item in ar)
        //{

        //}

        return ar.Sum();
    }
}