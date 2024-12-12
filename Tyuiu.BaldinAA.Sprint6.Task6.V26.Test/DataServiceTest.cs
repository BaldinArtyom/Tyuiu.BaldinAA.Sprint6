using Tyuiu.BaldinAA.Sprint6.Task6.V26.Lib;

namespace Tyuiu.BaldinAA.Sprint6.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask6V26.txt");
            string res = ds.CollectTextFromFile(path);
            Console.WriteLine(res);
        }
    }
}