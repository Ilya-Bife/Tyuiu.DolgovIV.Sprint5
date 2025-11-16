internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array = { { -9, 10, 2 }, { 4, -8, 1 }, { 5, 3, -6 } };
        int rowSum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[1, j];
        }

        File.WriteAllText("OutPutFileTask2.csv", rowSum.ToString());
    }
}