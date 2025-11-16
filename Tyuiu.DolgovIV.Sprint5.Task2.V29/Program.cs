using Tyuiu.DolgovIV.Sprint5.Task2.V29.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        
        

        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] matr = { { 9, 2, 5 }, { 3, 2, 4 }, { 2, 8, 8 } };

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Файл:" + ds.SaveToFileTextData(matr));


        Console.ReadKey();
    }
}