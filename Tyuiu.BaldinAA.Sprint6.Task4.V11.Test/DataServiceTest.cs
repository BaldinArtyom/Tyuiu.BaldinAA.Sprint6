using Tyuiu.BaldinAA.Sprint6.Task4.V11.Lib;
namespace Tyuiu.BaldinAA.Sprint6.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5; int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { 20.36, 15.42, 10.99, 7.43, 4.33, 1, 0.00, -8.87, -13.03, -16.53, -19.6 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}