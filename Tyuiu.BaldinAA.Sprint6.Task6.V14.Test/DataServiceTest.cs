using Tyuiu.BaldinAA.Sprint6.Task6.V14.Lib;
namespace Tyuiu.BaldinAA.Sprint6.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Artyom\source\repos\Tyuiu.BaldinAA.Sprint6\Tyuiu.BaldinAA.Sprint6.Task6.V14\bin\Debug\InPutFileTask6V14.txt";
            string wait = " GzTsc AucHJjziZ jiUFMDjMsEervIz ziwVyU";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\Users\Artyom\source\repos\Tyuiu.BaldinAA.Sprint6\Tyuiu.BaldinAA.Sprint6.Task6.V14\bin\Debug\InPutFileTask6V14.txt";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }
    }
}