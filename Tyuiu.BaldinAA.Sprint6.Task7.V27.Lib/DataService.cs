using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BaldinAA.Sprint6.Task7.V27.Lib
{
    public class DataService : ISprint6Task7V27
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            string[] file = File.ReadAllText(path).Split('\n');
            string[] cs = file[4].Split(';');
            int[,] m = new int[file.Length, file[0].Split(';').Length];
            for (int i = 0; i < file[0].Split(';').Length; i++)
            {

                if (int.Parse(cs[i]) < 0) { cs[i] = "-1"; };
            }
            file[4] = string.Join(';', cs);
            for (int i = 0; i < file[0].Split(';').Length; i++)
            {
                for (int j = 0; j < file.Length; j++)
                {
                    m[i, j] = int.Parse(file[i].Split(';')[j]);
                }
            }
            return m; 
        }
    }
}
