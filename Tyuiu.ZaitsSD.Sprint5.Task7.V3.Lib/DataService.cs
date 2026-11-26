using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZaitsSD.Sprint5.Task7.V3.Lib
{
    public class DataService : ISprint5Task7V3
    {
        public string LoadDataAndSave(string path)
        {
            string PathSave = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V3.txt");
            string text = File.ReadAllText(path);
            System.Text.StringBuilder res = new System.Text.StringBuilder(text.Length);
            foreach (char symbol in text)
            {
                if (!((symbol >= 'А' && symbol <= 'Я') || (symbol >= 'а' && symbol <= 'я') || symbol == 'Ё' || symbol == 'ё'))
                {
                    res.Append(symbol);
                }
            }
            File.WriteAllText(PathSave, res.ToString());
            return PathSave;
        }
    }
}
