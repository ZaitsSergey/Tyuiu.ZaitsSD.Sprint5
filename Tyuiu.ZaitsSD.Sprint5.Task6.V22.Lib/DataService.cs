using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZaitsSD.Sprint5.Task6.V22.Lib
{
    public class DataService : ISprint5Task6V22
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            int res = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == 'м' && text[i + 1] == 'м') res++;
            }
            return res;
        }
    }
}
