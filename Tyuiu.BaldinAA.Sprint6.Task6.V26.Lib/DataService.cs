using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BaldinAA.Sprint6.Task6.V26.Lib
{
    public class DataService: ISprint6Task6V26
    {
        public string CollectTextFromFile(string path)
        {
            string[] words = File.ReadAllText(path).Split("\n");
            string res = "";
            int spaceindex = 0;
            for (int i = 0; i < words.Length; i++) 
            {
                if (words[i] != "")
                {
                    spaceindex = words[i].LastIndexOf(" ");
                    res += words[i].Substring(spaceindex);
                }
            }
            return res.Trim();
        }

        public string CollectTextFromFile(string str, string path)
        {
            throw new NotImplementedException();
        }
    }
}

/*Дан файл InPutFileTask6V26.txt который может находится в любом месте на диске. 
 * Загрузить файл в textBoxIn через openFileDialog.
 * Вывести последнее слово каждой строки в результирующею строку и вывести ее в textBoxOut.*/