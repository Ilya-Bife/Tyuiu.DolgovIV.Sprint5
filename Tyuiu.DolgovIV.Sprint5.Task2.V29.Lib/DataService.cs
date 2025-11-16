using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DolgovIV.Sprint5.Task2.V29.Lib
{
    public class DataService : ISprint5Task2V29
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            string str = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j != matrix.GetLength(1) - 1)
                    {
                        if (matrix[i, j] % 2 != 0)
                        {
                            str += "0" + ";";
                        }
                        else
                        {
                            str += $"{matrix[i, j]}" + ";";
                        }
                    }
                    else
                    {
                        if (matrix[i, j] % 2 != 0)
                        {
                            str += "0";
                        }
                        else
                        {
                            str += $"{matrix[i, j]}";
                        }
                    }

                    
                }
                if (i != matrix.GetLength(0) - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";

            }
            return path;
        }
    }
}
