using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DolgovIV.Sprint5.Task5.V11.Lib
{
    public class DataService : ISprint5Task5V11
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;

            string x = File.ReadAllText(path);
            x = x.Replace('.', ',');
            string[] strings = x.Split(' ');
            foreach (var item in strings)
            {
                if (Convert.ToDouble(item) % 2 != 0 && (Convert.ToString(Convert.ToDouble(item)*10) == item + '0')) 
                {
                    res *= Convert.ToDouble(item);
                }
            }
            return res;
        }
    }
}
