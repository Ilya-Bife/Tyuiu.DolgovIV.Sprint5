using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DolgovIV.Sprint5.Task1.V28.Lib
{
    public class DataService : ISprint5Task1V28
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            for (int x = startValue; x <= stopValue; x++)
            {
                double res = Math.Cos(x) / (x - 0.7) - Math.Sin(x) * 12 * x + 2;
                if (double.IsInfinity(res) || double.IsNaN(res))
                {
                    res = 0;
                }
                res = Math.Round(res, 2);
                File.AppendAllText(path, $"{res}\n");
            }
            return path;
        }
    }
}
