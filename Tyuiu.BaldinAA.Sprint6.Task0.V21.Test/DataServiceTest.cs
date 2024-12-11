using Tyuiu.BaldinAA.Sprint6.Task0.V21.Lib;
namespace Tyuiu.BaldinAA.Sprint6.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}