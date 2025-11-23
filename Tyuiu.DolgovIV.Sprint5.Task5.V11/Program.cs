using Tyuiu.DolgovIV.Sprint5.Task5.V11.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask5V11.txt";


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");



        Console.WriteLine(ds.LoadFromDataFile(path));


        Console.ReadKey();
    }
}