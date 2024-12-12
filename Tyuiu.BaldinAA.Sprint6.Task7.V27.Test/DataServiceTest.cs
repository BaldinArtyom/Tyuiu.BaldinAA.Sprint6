using Tyuiu.BaldinAA.Sprint6.Task7.V27.Lib;

namespace Tyuiu.BaldinAA.Sprint6.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask7V27.csv");
            int[,] res = ds.GetMatrix(path);
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    Console.Write(res[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}