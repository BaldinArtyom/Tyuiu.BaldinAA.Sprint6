using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BaldinAA.Sprint6.Task7.V27.Lib
{
    public class DataService: ISprint6Task7V27
    {
        public int[,] GetMatrix(string path)
        {
            string[] input = File.ReadAllText(path).Split("\n");

            int count = input[0].Split(";").Length;
            while (input[input.Length-1] == "")
            {
                count--;
            }
            string[] nums;
            int[,] res = new int[input.Length, count];
            for (int i = 0; i < res.GetLength(0); i++)
            {
                if (input[i] != "")
                {
                    nums = input[i].Split(";");
                    for (int j = 0; j < res.GetLength(1); j++)
                    {
                        res[i, j] = Convert.ToInt32(nums[j]);
                        if (res[4, j] < 0) res[4, j] = -1;
                    }
                }
            }
            return res;
        }
    }
}
