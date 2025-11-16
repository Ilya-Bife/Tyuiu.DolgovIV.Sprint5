using Tyuiu.DolgovIV.Sprint5.Task0.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        

        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 3;
        Console.WriteLine("x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");



        Console.WriteLine("Файл:" + ds.SaveToFileTextData(x));


        Console.ReadKey();
    }
}