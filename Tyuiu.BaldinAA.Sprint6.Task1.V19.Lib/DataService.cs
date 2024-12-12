using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BaldinAA.Sprint6.Task1.V19.Lib
{
    public class DataService : ISprint6Task1V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            for (int i = 0; i < res.Length; i++)
            {
                if (i-stopValue == -2)
                {
                    res[i] = 0;
                }
                else
                {
                    res[i] = Math.Round(Math.Cos(i-stopValue) + (Math.Cos(i-stopValue)) / (i-stopValue + 2) - 3 * (i-stopValue), 3);
                }
            }
            return res; 
        }
    }
}
