using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BaldinAA.Sprint6.Task4.V11.Lib
{
    public class DataService : ISprint6Task4V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((2 - 2 * x) != 0)
                {
                    y = Math.Round(Math.Cos(x) + Math.Sin(x) / (2 - 2 * x) - 4 * x, 2);
                    valueArray[count] = y;
                    count++;
                }
                else
                {
                    y = 0.00;
                    valueArray[count] = y;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
