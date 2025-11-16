using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DolgovIV.Sprint5.Task2.V29.Lib
{
    public class DataService : ISprint5Task2V29
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        File.AppendAllText(path, $"{0}\n");
                    }
                    else
                    {
                        File.AppendAllText(path, $"{matrix[i, j]}\n");
                    }
                }
            }
            return path;
        }
    }
}
