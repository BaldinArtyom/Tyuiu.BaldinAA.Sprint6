using Tyuiu.BaldinAA.Sprint6.Task6.V26.Lib;
namespace Tyuiu.BaldinAA.Sprint6.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Artyom\source\repos\Tyuiu.BaldinAA.Sprint6\Tyuiu.BaldinAA.Sprint6.Task6.V26\bin\Debug\net8.0-windows\InPutFileTask6v26.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}