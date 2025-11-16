using Tyuiu.DolgovIV.Sprint5.Task1.V28.Lib;

namespace Tyuiu.DolgovIV.Sprint5.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Илья\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
