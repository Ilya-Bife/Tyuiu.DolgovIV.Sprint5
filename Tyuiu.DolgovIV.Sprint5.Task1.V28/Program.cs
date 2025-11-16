using Tyuiu.DolgovIV.Sprint5.Task1.V28.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");



        Console.WriteLine("Файл:" + ds.SaveToFileTextData(startValue, stopValue));


        Console.ReadKey();
    }
}