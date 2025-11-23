using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DolgovIV.Sprint5.Task7.V25.Lib
{
    public class DataService : ISprint5Task7V25
    {
        public string LoadDataAndSave(string path)
        {
            string Endpath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V25.txt");

            FileInfo fileInfo = new FileInfo(Endpath);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(Endpath);
            }

            string endstr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (var item in line)
                    {
                        if (!"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(item))
                        {
                            endstr += item;
                        }
                    }
                }
            }
            File.AppendAllText(path, endstr);
            return path;
            
        }
    }
}
