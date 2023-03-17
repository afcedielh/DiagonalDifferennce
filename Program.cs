class Result
{
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int DiagonalDifference(List<List<int>> arr)
    {
        return Math.Abs(Enumerable.Range(0, arr.Count).Sum(i => arr[i][i]) - Enumerable.Range(0, arr.Count).Sum(i => arr[i][arr.Count - i - 1]));
    }

}

class Solution
{
    public static void Main()
    {
        List<List<int>> arr = new()
        {
            new List<int>() { 1, 2, 3 },
            new List<int>() { 4, 5, 6 },
            new List<int>() { 7, 8, 9 }
        };
        _ = Result.DiagonalDifference(arr);
    }
}
