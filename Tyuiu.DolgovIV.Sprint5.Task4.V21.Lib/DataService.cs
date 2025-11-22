using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DolgovIV.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            string x = File.ReadAllText(path);
            int l = 0;
            x = x.Replace('.', ',');
            double res = Math.Pow(Convert.ToDouble(x), 3) * Math.Cos(Convert.ToDouble(x)) + 2 * Convert.ToDouble(x);
            return Math.Round(res,3);
        }
    }
}
